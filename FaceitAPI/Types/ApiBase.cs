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
        protected IAuthorizable Authorizable { get; private set; }
        protected HttpClient Http;

        public ApiBase()
        {
            Http = new HttpClient();
        }

        public void SetAuthorizable(IAuthorizable authorizable, bool addheader = true)
        {
            Authorizable = authorizable;

            if (addheader)
                Http.DefaultRequestHeaders.Add("Authorization", Authorizable.GetBearer());
        }
        
        public IAuthorizable GetAuthorizable()
        {
            return Authorizable;
        }

        protected T Get<T>(string query, HttpStatusCode expected = HttpStatusCode.OK)
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
