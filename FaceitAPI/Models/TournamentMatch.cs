using System;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class TournamentMatch
    {
        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("results")]
        public MatchResults MatchResults { get; set; }

        [JsonProperty("round")]
        public int? Round { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("teams")]
        [Obsolete("pending edit.")]
        public object Teams { get; set; }
    }
}