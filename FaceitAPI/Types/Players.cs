using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Players : ApiBase, IPlayers
    {
        public Players(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public PlayerMatchesPaging<PlayerMatch> GetHistory(string player_id, string game, ulong from = 0, ulong to = 4102448461, int offset = 0, int limit = 20)
        {
            return Get<PlayerMatchesPaging<PlayerMatch>>($"https://open.faceit.com/data/v4/players/{player_id}/history?game={game}&from={from}&to={to}&offset={offset}&limit={limit}");
        }

        public Paging<HubDetails> GetHubs(string player_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<HubDetails>>($"https://open.faceit.com/data/v4/players/{player_id}/hubs?offset={offset}&limit={limit}");
        }

        public PlayerDetails GetPlayer(string nickname, string game, string game_player_id)
        {
            return Get<PlayerDetails>($"https://open.faceit.com/data/v4/players?nickname={nickname}&game={game}&game_player_id={game_player_id}");
        }

        public PlayerDetails GetPlayerById(string player_id)
        {
            return Get<PlayerDetails>($"https://open.faceit.com/data/v4/players/{player_id}");
        }

        public Statistics GetStatistics(string player_id, string game_id)
        {
            return Get<Statistics>($"https://open.faceit.com/data/v4/players/{player_id}/stats/{game_id}");
        }

        public Paging<Tournament> GetTournaments(string player_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<Tournament>>($"https://open.faceit.com/data/v4/players/{player_id}/tournaments?offset={offset}&limit={limit}");
        }
    }
}
