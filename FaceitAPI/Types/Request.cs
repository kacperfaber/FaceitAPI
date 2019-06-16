using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FaceitAPI.Types
{
    public class Request
    {
        public static readonly string BaseUrl = "https://open.faceit.com/data/v4";

        public string Url;
        public HttpMethod Method;
        public HttpClient HttpClient;
        public Dictionary<string, string> Headers = new Dictionary<string, string>();

        public RequestResult Execute()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = Method;
            request.RequestUri = new Uri(Url);

            foreach (var item in Headers)
            {
                request.Headers.Add(item.Key, item.Value);
            }

            HttpResponseMessage response = HttpClient.SendAsync(request).Result;
            string json = response.Content.ReadAsStringAsync().Result;

            RequestResult result = new RequestResult();
            result.Success = response.IsSuccessStatusCode;
            result.Content = json;
            result.StatusCode = response.StatusCode;

            return result;
        }
    }
}