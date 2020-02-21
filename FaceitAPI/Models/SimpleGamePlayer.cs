using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleGamePlayer
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("faceit_elo")]
        public int? FaceitElo { get; set; }

        [JsonProperty("game_skill_level")]
        public int? GameSkillLevel { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }
    }
}