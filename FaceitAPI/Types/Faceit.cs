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
                T instance = (T) Activator.CreateInstance(typeof(T), Authorizable);

                RegisterObject<T>(instance);
                return instance;
            }
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
