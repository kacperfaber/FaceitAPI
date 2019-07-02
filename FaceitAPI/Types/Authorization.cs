using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Authorization : IAuthorizable
    {
        public string Key { get; set; }

        public static readonly string Header = "Authorization";

        public Authorization(string apikey)
        {
            Key = apikey;
        }

        public string GetBearer()
        {
            return "Bearer " + Key;
        }

        public string GetHeaderName()
        {
            return Header;
        }
    }
}
