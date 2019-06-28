using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class TeamStatistics
    {
        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("lifetime")]
        public Dictionary<string, object> Lifetime { get; set; }

        [JsonProperty("segments")]
        public TeamStatisticsSegment[] Segments { get; set; }
    }
}
