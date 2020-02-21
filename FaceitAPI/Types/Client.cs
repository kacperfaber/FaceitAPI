using System;
using System.Net.Http;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Client : IHttpClient
    {
        public const string ContentType = "ContentType";
        public const string MimeContentType = "application/json";

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