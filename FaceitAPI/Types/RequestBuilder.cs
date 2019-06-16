using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class RequestBuilder
    {
        private HttpClient httpClient = new HttpClient();
        private IAuthorization authorization;

        public RequestBuilder(IAuthorization auth)
        {
            authorization = auth;
        }

        public Request CreateRequest(string url, HttpMethod method)
        {
            Request req = new Request();
            req.Url = Request.BaseUrl + "/" + url;
            req.Method = method;
            req.HttpClient = httpClient;
            req.Headers.Add("Authorization", authorization.GetBearer());

            return req;
        }
    }
}
