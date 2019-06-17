using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Models
{
    public class Authorization : IAuthorizable
    {
        private string Key;

        public Authorization(string key)
        {
            Key = key;
        }

        public string GetBearer()
        {
            return "Bearer " + Key;
        }
    }
}
