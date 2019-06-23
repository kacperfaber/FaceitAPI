using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Interfaces
{
    public interface IResponse
    {
        void SetResponse(string response);

        string GetResponse();
    }
}
