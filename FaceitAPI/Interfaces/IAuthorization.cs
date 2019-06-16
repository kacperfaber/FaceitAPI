using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitAPI.Interfaces
{
    public interface IAuthorization
    {
        string GetBearer();

        bool IsEmpty();
    }
}
