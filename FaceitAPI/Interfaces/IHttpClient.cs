using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace FaceitAPI.Interfaces
{
    public interface IHttpClient
    {
        HttpResponseMessage SendRequest(string url, IAuthorizable authorizable);
    }
}
