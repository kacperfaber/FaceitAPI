using System;

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