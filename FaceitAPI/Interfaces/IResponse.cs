using System.Net.Http;

namespace FaceitAPI.Interfaces
{
    public interface IResponse
    {
        void ReadResponse(string response, HttpResponseMessage message);
    }
}