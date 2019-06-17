using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Requests;
using Newtonsoft.Json;

namespace FaceitAPI.Types
{
    public class Api
    {
        // api key
        public IAuthorizable Authorizable;

        private HttpClient Http;

        public Api(IAuthorizable auth)
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
