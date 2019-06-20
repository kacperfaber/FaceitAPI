using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IPlayers
    {
        PlayerDetails PlayerDetails(string playerid);

        // and lot more
    }
}
