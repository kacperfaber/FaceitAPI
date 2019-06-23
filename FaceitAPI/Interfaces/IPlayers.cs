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

        Paging<Match> GetPlayerHistory(string playerid, string game = "csgo", string from = "", string to = "", int offset = 0, int limit = 20);

        Statistic GetPlayerStatistic(string playerid, string gameid = "csgo");

        Paging<Hub> GetPlayerHubs(string playerid, int offset = 0, int limit = 20);

        Paging<Tournament> GetPlayerTournaments(string playerid, int offset = 0, int limit = 20);
    }
}
