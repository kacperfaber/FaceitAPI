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
        protected IAuthorizable Authorizable { get; private set; }
        protected HttpClient Http;

        public ApiBase()
        {
            Http = new HttpClient();
        }

        public ApiBase(IAuthorizable authorizable)
        {
            Http = new HttpClient();
            SetAuthorizable(authorizable);
        }

        protected void SetAuthorizable(IAuthorizable authorizable, bool addheader = true)
        {
            Authorizable = authorizable;

            if (addheader)
                Http.DefaultRequestHeaders.Add("Authorization", Authorizable.GetBearer());
        }
        
        protected IAuthorizable GetAuthorizable()
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

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedException();
            }

            throw new AggregateException("Received StatusCode is not excepted.\nThe status code is: " + response.StatusCode.ToString());
        }
    }
}
