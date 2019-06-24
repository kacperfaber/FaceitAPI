using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Faceit
    {
        public IAuthorizable Authorizable;
        private Dictionary<Type, ApiBase> Instances;

        public Faceit(IAuthorizable authorizable)
        {
            Instances = new Dictionary<Type, ApiBase>();
            Authorizable = authorizable;
        }

        public T Get<T>() 
            where T : ApiBase
        {
            Type type = typeof(T);

            if (Instances.ContainsKey(type))
            {
                return (T) Instances[type];
            }

            else
            {
                ApiBase apibase = (ApiBase) Activator.CreateInstance(type);
                apibase.SetAuthorizable(Authorizable);

                Instances.Add(type, apibase);
                return (T) Instances[type];
            }
        }
    }
}
