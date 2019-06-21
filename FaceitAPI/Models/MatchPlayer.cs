using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class MatchPlayer
    {
        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty("game_player_id")]
        public string GamePlayerId { get; set; }

        [JsonProperty("game_player_name")]
        public string GamePlayerName { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }
    }
}