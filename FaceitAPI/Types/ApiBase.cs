using System;
using System.Net;
using System.Net.Http;
using FaceitAPI.Exceptions;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class ApiBase
    {
        protected IAuthorizable Authorizable;

        public IJsonDeserializer Deserializer;
        public IHttpClient HttpClient;
        public IResponse Response;
        private string ResponseContent;

        private HttpResponseMessage ResponseMessage;

        public ApiBase(IAuthorizable authorizable, IHttpClient http = null, IJsonDeserializer deserializer = null)
        {
            Authorizable = authorizable;

            HttpClient = http ?? new Client();
            Deserializer = deserializer ?? new JsonDeserializer();
        }

        protected T Get<T>(string url)
        {
            try
            {
                ResponseMessage = HttpClient.SendRequest(url, Authorizable);
                ResponseContent = ResponseMessage.Content.ReadAsStringAsync().Result;
                T t = Deserializer.Deserialize<T>(ResponseContent);

                Response?.ReadResponse(ResponseContent, ResponseMessage);

                return t;
            }

            catch (Exception e)
            {
                if (ResponseMessage.StatusCode == HttpStatusCode.Unauthorized)
                    throw new UnauthorizedException();

                throw e;
            }
        }

        protected T Get<T>(string url, out IResult result)
        {
            throw new NotImplementedException();
        }

        public IApiResponse Get(IApiRequest request)
        {
            // TODO with IApiRequest builders.
            // 
            
            throw new NotImplementedException();
        }
    }
}