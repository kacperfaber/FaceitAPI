using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IPlayers : IApiBase
    {
        PlayerDetails GetPlayer(string nickname, string game, string game_player_id);

        PlayerDetails GetPlayerById(string player_id);

        PlayerMatchesPaging<PlayerMatch> GetHistory(string player_id, string game, ulong from = 0, ulong to = 4102448461, int offset = 0, int limit = 20);

        Paging<HubDetails> GetHubs(string player_id, int offset = 0, int limit = 20);

        Statistics GetStatistics(string player_id, string game_id);

        Paging<Tournament> GetTournaments(string player_id, int offset = 0, int limit = 20);
    }
}
