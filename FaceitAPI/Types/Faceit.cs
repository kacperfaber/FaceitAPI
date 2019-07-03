using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Faceit : SimpleContainer<ApiBase>
    {
        public IAuthorizable Authorizable;

        public Faceit(IAuthorizable authorizable)
        {
            if (authorizable == null)
            {
                throw new ArgumentException($"IAuthorizable authorizable on {GetType().FullName} cannot be null");
            }

            Authorizable = authorizable;
        }

        public T GetObject<T>() where T : ApiBase
        {
            if (Exist<T>())
            {
                return Get<T, T>();
            }

            else
            {
                ApiBase instance = (ApiBase) Activator.CreateInstance(typeof(T), Authorizable);
                
                RegisterObject<T>(instance);
                return (T) instance;
            }
        }

        public T GetObject<T>(IResponse response) where T : ApiBase
        {
            var obj = GetObject<T>();
            obj.Response = response;

            return (T) obj;
        }

        public T GetObject<T>(IHttpClient http) where T : ApiBase
        {
            var obj = GetObject<T>();
            obj.HttpClient = http;

            return (T) obj;
        }

        public T GetObject<T>(IResponse response = null, IHttpClient http = null, IJsonDeserializer deserializer = null) where T : ApiBase
        {
            if (base.Exist<T>())
            {
                UnregisterObject<T>();
            }

            ApiBase api = GetObject<T>();
            
            if (response != null) api.Response = response;
            if (http != null) api.HttpClient = http;
            if (deserializer != null) api.Deserializer = deserializer;

            return (T) api;
        }

        public void Set<T>(T t) where T : ApiBase
        {
            base.Set<T>(t);
        }

        public void DestroyObject<T>()
        {
            UnregisterObject<T>();
        }
    }
}
