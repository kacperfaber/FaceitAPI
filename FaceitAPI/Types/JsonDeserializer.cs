using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using Newtonsoft.Json;

namespace FaceitAPI.Types
{
    public class JsonDeserializer : IJsonDeserializer
    {
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
