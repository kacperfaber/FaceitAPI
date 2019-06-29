using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Leaderboards : ApiBase, ILeaderboards
    {
        public Leaderboards(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public LeaderboardPaging<Ranking> GetChampionshipGroup(string championship_id, int group, int offset = 0, int limit = 20)
        {
            return Get<LeaderboardPaging<Ranking>>($"https://open.faceit.com/data/v4/leaderboards/championships/{championship_id}/groups/{group}?offset={offset}&limit={limit}");
        }

        public Paging<LeaderboardDetails> GetChampionshipLeaderboards(string championship_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<LeaderboardDetails>>($"https://open.faceit.com/data/v4/leaderboards/championships/{championship_id}?offset={offset}&limit={limit}");
        }

        public Paging<LeaderboardDetails> GetHubLeaderboards(string hub_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<LeaderboardDetails>>($"https://open.faceit.com/data/v4/leaderboards/hubs/{hub_id}?offset={offset}&limit={limit}");
        }

        public LeaderboardPaging<Ranking> GetHubRanking(string hub_id, int offset = 0, int limit = 20)
        {
            return Get<LeaderboardPaging<Ranking>>($"https://open.faceit.com/data/v4/leaderboards/hubs/{hub_id}/general?offset={offset}&limit={limit}");
        }

        public LeaderboardPaging<Ranking> GetLeaderboard(string leaderboard_id, int offset = 0, int limit = 20)
        {
            return Get<LeaderboardPaging<Ranking>>($"https://open.faceit.com/data/v4/leaderboards/{leaderboard_id}?offset={offset}&limit={limit}");
        }

        public LeaderboardPaging<Ranking> GetSeasonHubRanking(string hub_id, int season, int offset = 0, int limit = 20)
        {
            return Get<LeaderboardPaging<Ranking>>($"https://open.faceit.com/data/v4/leaderboards/hubs/{hub_id}/seasons/{season}?offset={offset}&limit={limit}");
        }
    }
}
