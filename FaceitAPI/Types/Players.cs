using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Players : Api, IPlayers
    {
        public Players(IAuthorizable auth) : base(auth)
        {
            base.Authorizable = auth;
        }

        public PlayerDetails PlayerDetails(string playerid)
        {
            return Get<PlayerDetails>($"https://open.faceit.com/data/v4/players/{playerid}");
        }
    }
}
