using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IPlayers
    {
        PlayerDetails GetPlayerDetails(string playerid);

        PlayerDetails GetPlayerDetails(string playerid, string game, string gameplayerid);

        History GetPlayerHistory(string playerid, string game, string from = "", string to = "", int offset = 0, int limit = 20);

        Statistic GetPlayerStatistic(string playerid, string gameid);

        Hubs GetPlayerHubs(string playerid, int offset = 0, int limit = 20);

        Tournaments GetPlayerTournaments(string playerid, int offset = 0, int limit = 20);
    }
}
