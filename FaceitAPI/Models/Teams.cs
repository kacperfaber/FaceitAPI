using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Teams
    {
        [JsonProperty("faction1")]
        public MatchTeam TeamA { get; set; }

        [JsonProperty("faction2")]
        public MatchTeam TeamB { get; set; }
    }
}