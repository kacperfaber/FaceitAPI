using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Authorization : IAuthorization
    {
        private string Key;

        public Authorization(string apikey)
        {
            Key = apikey;
        }

        public string GetBearer()
        {
            return $"Bearer {Key}";
        }

        // bad working i turn off it.
        public bool IsEmpty()
        {
            return true;
        }
    }
}
