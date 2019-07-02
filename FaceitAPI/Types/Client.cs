using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Client : IHttpClient
    {
        public static readonly string ContentType = "ContentType";
        public static readonly string MimeContentType = "application/json";

        public HttpMethod HttpMethod = HttpMethod.Get;

        public HttpResponseMessage SendRequest(string url, IAuthorizable authorizable)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.Headers.Add(authorizable.GetHeaderName(), authorizable.GetBearer());
            request.Headers.Add(ContentType, MimeContentType);
            request.RequestUri = new Uri(url);
            request.Method = HttpMethod;

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = httpClient.SendAsync(request).Result;

            return responseMessage;
        }
    }
}
