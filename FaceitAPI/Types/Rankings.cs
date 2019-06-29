using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Rankings : ApiBase, IRankings
    {
        public Rankings(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public RankingPaging<SimpleGamePlayer> GetGlobalPositionForPlayer(string game_id, string region, string player_id, string country, int limit = 20)
        {
            return Get<RankingPaging<SimpleGamePlayer>>($"https://open.faceit.com/data/v4/rankings/games/{game_id}/regions/{region}/players/{player_id}?country={country}&limit={limit}");
        }

        public Paging<SimpleGamePlayer> GetGlobalRankingForGame(string game_id, string region, string country, int offset = 0, int limit = 20)
        {
            return Get<Paging<SimpleGamePlayer>>($"https://open.faceit.com/data/v4/rankings/games/{game_id}/regions/{region}?country={country}&offset={offset}&limit={limit}");
        }
    }
}
