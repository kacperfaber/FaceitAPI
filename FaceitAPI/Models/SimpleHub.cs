using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleHub
    {
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }
    }
}