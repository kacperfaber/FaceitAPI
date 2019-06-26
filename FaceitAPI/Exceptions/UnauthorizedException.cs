using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException() : 
            base("throwed UnauthorizedException.")
        {
        }
    }
}
