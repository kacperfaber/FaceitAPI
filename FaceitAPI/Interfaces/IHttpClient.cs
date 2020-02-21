using System.Net.Http;

namespace FaceitAPI.Interfaces
{
    public interface IHttpClient
    {
        HttpResponseMessage SendRequest(string url, IAuthorizable authorizable);
    }
}