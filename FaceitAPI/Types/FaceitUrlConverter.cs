using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class FaceitUrlConverter : IUrlConverter
    {
        public static readonly string LangSign = "{lang}";

        public string Convert(string language, string input)
        {
            return input.Replace("{lang}", language);
        }
    }
}
