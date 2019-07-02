using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using FaceitAPI.Exceptions;
using FaceitAPI.Interfaces;
using Newtonsoft.Json;

namespace FaceitAPI.Types
{
    public class ApiBase
    {
        protected IAuthorizable Authorizable;
        public IResponse Response;
        public IHttpClient HttpClient = new Client();
        public IJsonDeserializer Deserializer = new JsonDeserializer();

        private HttpResponseMessage ResponseMessage;
        private string ResponseContent;

        public ApiBase(IAuthorizable authorizable)
        {
            Authorizable = authorizable;
        }

        protected T Get<T>(string url)
        {
            ResponseMessage = HttpClient.SendRequest(url, Authorizable);
            ResponseContent = ResponseMessage.Content.ReadAsStringAsync().Result;
            object instance = Deserializer.Deserialize<T>(ResponseContent);

            if (Response != null)
                Response.ReadResponse(ResponseContent, ResponseMessage);

            return (T) instance;
        }
    }
}
