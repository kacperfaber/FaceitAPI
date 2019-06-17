using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Requests
{
    public class UrlParametersBuilder : Dictionary<string, object>
    {
        public string GetString()
        {
            bool isfirst = true;

            StringBuilder b = new StringBuilder();
            b.Append("?");

            foreach (var key in Keys)
            {
                if (isfirst)
                    isfirst = false;
                else 
                    b.Append("&");

                b.Append($"{key}={this[key]}");
            }

            return b.ToString();
        }
    }
}