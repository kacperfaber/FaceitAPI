using System.Net;

namespace FaceitAPI.Types
{
    public class RequestResult
    {
        public string Content;
        public bool Success;
        public HttpStatusCode StatusCode;
    }
}