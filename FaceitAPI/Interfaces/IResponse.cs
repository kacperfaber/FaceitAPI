using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FaceitAPI.Interfaces
{
    public interface IResponse
    {
        void ReadResponse(string response, HttpResponseMessage message);
    }
}
