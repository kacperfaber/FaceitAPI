using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Brackets
    {
        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("matches")]
        public TournamentMatch[] Matches { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rounds")]
        public Round[] Rounds { get; set; }
    }
}
