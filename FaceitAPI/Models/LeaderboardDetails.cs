using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class LeaderboardDetails
    {
        [JsonProperty("competition_id")]
        public string CompetitionId { get; set; }

        [JsonProperty("competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty("end_date")]
        public ulong? EndDate { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("group")]
        public int? Group { get; set; }

        [JsonProperty("leaderboard_id")]
        public string LeaderboardId { get; set; }

        [JsonProperty("leaderboard_mode")]
        public string LeaderboardMode { get; set; }

        [JsonProperty("leaderboard_name")]
        public string LeaderboardName { get; set; }

        [JsonProperty("leaderboard_type")]
        public string LeaderboardType { get; set; }

        [JsonProperty("min_matches")]
        public int? MinMatches { get; set; }

        [JsonProperty("points_per_draw")]
        public int? PointsPerDraw { get; set; }

        [JsonProperty("points_per_loss")]
        public int? PointsPerLoss { get; set; }

        [JsonProperty("points_per_win")]
        public int? PointsPerWin { get; set; }

        [JsonProperty("points_type")]
        public string PointsType { get; set; }

        [JsonProperty("ranking_boost")]
        public int RankingBoost { get; set; }

        [JsonProperty("ranking_type")]
        public string RankingType { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("start_date")]
        public ulong? StartDate { get; set; }

        [JsonProperty("starting_points")]
        public int? StartingPoints { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
