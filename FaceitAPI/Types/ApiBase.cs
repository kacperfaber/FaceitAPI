using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using FaceitAPI.Interfaces;
using Newtonsoft.Json;

namespace FaceitAPI.Types
{
    public class ApiBase
    {
        // api key
        public IAuthorizable Authorizable;

        protected HttpClient Http;

        public ApiBase(IAuthorizable auth)
        {
            Http = new HttpClient();
            Http.DefaultRequestHeaders.Add("Authorization", auth.GetBearer());

            Authorizable = auth;
        }

        public T Get<T>(string query, HttpStatusCode expected = HttpStatusCode.OK)
        {
            var response = Http.GetAsync(query).Result;

            if (response.StatusCode == expected)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                T t = JsonConvert.DeserializeObject<T>(json);

                return t;
            }

            throw new AggregateException("Received StatusCode is not excepted.\nThe status code is: " + response.StatusCode.ToString());
        }
    }
}
