using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Response : IResponse
    {
        public Action<string, HttpResponseMessage> Action;

        public Response(Action<string, HttpResponseMessage> act)
        {
            Action = act;
        }

        public void ReadResponse(string response, HttpResponseMessage message)
        {
            Action.Invoke(response, message);
        }
    }
}
