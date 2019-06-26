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

        public void DestroyObject<T>()
        {
            UnregisterObject<T>();
        }
    }
}
