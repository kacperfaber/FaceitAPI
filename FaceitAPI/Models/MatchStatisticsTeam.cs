using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchStatisticsTeam
    {
        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("premade")]
        public bool? Premade { get; set; }

        [JsonProperty("team_stats")]
        public Dictionary<string, string> TeamStatistics { get; set; }

        [JsonProperty("players")]
        public MatchStatisticsPlayer[] Players { get; set; }
    }
}