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

        public History GetPlayerHistory(string playerid, string game, string from = "", string to = "", int offset = 0, int limit = 20)
        {
            return Get<History>($"https://open.faceit.com/data/v4/players/{playerid}/history?game={game}&from={from}&to={to}&offset={offset}&limit={limit}");
        }

        public Hubs GetPlayerHubs(string playerid, int offset = 0, int limit = 20)
        {
            return Get<Hubs>($"https://open.faceit.com/data/v4/players/{playerid}/hubs?offset={offset}&limit={limit}");
        }

        public Statistic GetPlayerStatistic(string playerid, string gameid)
        {
            return Get<Statistic>($"https://open.faceit.com/data/v4/players/{playerid}/stats/{gameid}");
        }

        public Tournaments GetPlayerTournaments(string playerid, int offset = 0, int limit = 20)
        {
            return Get<Tournaments>($"https://open.faceit.com/data/v4/players/{playerid}/tournaments?offset={offset}&limit={limit}");
        }
    }
}
