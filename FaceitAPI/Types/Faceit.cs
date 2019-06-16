using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;

namespace FaceitAPI.Types
{
    public class Faceit
    {
        public IAuthorization Authorization;

        public Faceit()
        {
            
        }

        public Faceit(string apikey)
        {
            Authorization = new Authorization(apikey);
        }
    }
}
