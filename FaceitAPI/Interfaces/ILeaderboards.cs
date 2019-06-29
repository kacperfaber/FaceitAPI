using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface ILeaderboards
    {
        Paging<LeaderboardDetails> GetChampionshipLeaderboards(string championship_id, int offset = 0, int limit = 20);

        LeaderboardPaging<Ranking> GetChampionshipGroup(string championship_id, int group, int offset = 0, int limit = 20); 

        Paging<LeaderboardDetails> GetHubLeaderboards(string hub_id, int offset = 0, int limit = 20);

        LeaderboardPaging<Ranking> GetHubRanking(string hub_id, int offset = 0, int limit = 20);

        LeaderboardPaging<Ranking> GetSeasonHubRanking(string hub_id, int season, int offset = 0, int limit = 20);

        LeaderboardPaging<Ranking> GetLeaderboard(string leaderboard_id, int offset = 0, int limit = 20);
    }
}
