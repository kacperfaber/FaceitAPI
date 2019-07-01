using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Roster
    {
        [JsonProperty("anticheat_required")]
        public bool? AnticheatRequired { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("game_player_id")]
        public string GamePlayerId { get; set; }

        [JsonProperty("game_player_name")]
        public string GamePlayerName { get; set; }

        [JsonProperty("game_skill_level")]
        public int? GameSkillLevel { get; set; }

        [JsonProperty("membership")]
        public string Membership { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }
    }
}