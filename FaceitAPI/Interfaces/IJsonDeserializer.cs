using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Interfaces
{
    public interface IJsonDeserializer
    {
        T Deserialize<T> (string json);
    }
}
