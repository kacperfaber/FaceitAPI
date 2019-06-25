using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchRound
    {
        [JsonProperty("best_of")]
        public string BestOf { get; set; }

        [JsonProperty("competition_id")]
        public string CompetitionId { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("game_mode")]
        public string GameMode { get; set; }

        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("match_round")]
        public string RoundMatch { get; set; }

        [JsonProperty("played")]
        public string Played { get; set; }

        [JsonProperty("round_stats")]
        public Dictionary<string, string> RoundStatistics { get; set; }

        [JsonProperty("teams")]
        public MatchStatisticsTeam[] Teams { get; set; }
    }
}