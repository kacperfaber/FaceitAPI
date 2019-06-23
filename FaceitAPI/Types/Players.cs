using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Players : ApiBase, IPlayers
    {
        public Players(IAuthorizable auth) : base(auth)
        {
            base.Authorizable = auth;
        }

        public PlayerDetails GetPlayerDetails(string playerid)
        {
            return Get<PlayerDetails>($"https://open.faceit.com/data/v4/players/{playerid}");
        }

        public PlayerDetails GetPlayerDetails(string nickname = "", string game = "", string gameplayerid = "")
        {
            return Get<PlayerDetails>($"https://open.faceit.com/data/v4/players?nickname={nickname}&game={game}&game_player_id={gameplayerid}");
        }

        public Paging<Match> GetPlayerHistory(string playerid, string game = "csgo", string from = "", string to = "", int offset = 0, int limit = 20)
        {
            return Get<Paging<Match>>($"https://open.faceit.com/data/v4/players/{playerid}/history?game={game}&from={from}&to={to}&offset={offset}&limit={limit}");
        }

        public Paging<Hub> GetPlayerHubs(string playerid, int offset = 0, int limit = 20)
        {
            return Get<Paging<Hub>>($"https://open.faceit.com/data/v4/players/{playerid}/hubs?offset={offset}&limit={limit}");
        }

        public Statistic GetPlayerStatistic(string playerid, string gameid = "csgo")
        {
            return Get<Statistic>($"https://open.faceit.com/data/v4/players/{playerid}/stats/{gameid}");
        }

        public Paging<Tournament> GetPlayerTournaments(string playerid, int offset = 0, int limit = 20)
        {
            return Get<Paging<Tournament>>($"https://open.faceit.com/data/v4/players/{playerid}/tournaments?offset={offset}&limit={limit}");
        }
    }
}
