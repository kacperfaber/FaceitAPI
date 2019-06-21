using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Team
    {
        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("players")]
        public MatchPlayer[] Players { get; set; }
    }
}