using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Types
{
    public class SimpleContainer <OUT>
    {
        private Dictionary<Type, OUT> Instances;

        public SimpleContainer()
        {
            Instances = new Dictionary<Type, OUT>();
        }

        protected void RegisterObject<T>(OUT obj)
        {
            if (!Exist<T>())
            {
                Instances.Add(typeof(T), obj);
            }

            else return;
        }

        protected void UnregisterObject<T>()
        {
            if (Exist<T>())
            {
                Instances.Remove(typeof(T));
            }
        }

        protected void Set<T>(OUT obj)
        {
            if (Exist<T>())
            {
                Instances[typeof(T)] = obj;
            }

            else return;
        }

        protected OUT Get<T>()
        {
            if (Exist<T>())
            {
                return (OUT) Instances[typeof(T)];
            }

            throw new ArgumentException($"{typeof(T).FullName} not exist in this SimpleContainer");
        }

        protected I Get<T, I>()
        {
            var get = Get<T>();
            return (I) Convert.ChangeType(get, typeof(I));
        }

        protected bool Exist<T>()
        {
            return Instances.ContainsKey(typeof(T));
        }
    }
}
