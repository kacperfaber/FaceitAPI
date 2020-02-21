using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchStatistics
    {
        [JsonProperty("rounds")]
        public MatchRound[] Rounds { get; set; }
    }
}