using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Requests
{
    public class UrlBuilder
    {
        public UrlParametersBuilder UrlParameters;
        public List<string> Segments;
        public string BaseUrl;

        public UrlBuilder()
        {
            UrlParameters = new UrlParametersBuilder();
            Segments = new List<string>();
        }

        public string GetString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(BaseUrl);
            builder.Append("/");

            foreach (string segment in Segments)
            {
                builder.Append(segment);
                builder.Append("/");
            }

            builder.Append(UrlParameters.GetString());
            return builder.ToString();
        }


    }
}
