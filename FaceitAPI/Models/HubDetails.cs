using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class HubDetails
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }

        [JsonProperty("chat_room_id")]
        public string ChatRoomId { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("game_data")]
        public GameData GameData { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        [JsonProperty("join_permission")]
        public string JoinPermission { get; set; }

        [JsonProperty("max_skill_level")]
        public int? MaxSkillLevel { get; set; }

        [JsonProperty("min_skill_level")]
        public int? MinSkillLevel { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizer_data")]
        public OrganizerDetails OrganizerData { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("players_joined")]
        public int? PlayersJoined { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("rule_id")]
        public string RuleId { get; set; }
    }
}