using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class FaceitUrls
    {
        public IUrlValidator UrlValidator;
        public IUrlConverter UrlConverter = new FaceitUrlConverter();

        public bool Validate(string url)
        {
            return UrlValidator.Validate(url);
        }

        public string GetUrl(string input, string lang)
        {
            return UrlConverter.Convert(lang, input);
        }
    }
}
