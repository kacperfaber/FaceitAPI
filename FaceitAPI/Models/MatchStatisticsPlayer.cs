using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchStatisticsPlayer
    {
        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("player_stats")]
        public Dictionary<string, string> PlayerStatistics { get; set; }
    }
}