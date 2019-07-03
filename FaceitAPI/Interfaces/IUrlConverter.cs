using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Interfaces
{
    public interface IUrlConverter
    {
        string Convert(string language, string input);
    }
}
