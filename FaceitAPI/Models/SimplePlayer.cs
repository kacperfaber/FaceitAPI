using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimplePlayer
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("games")]
        public SimplePlayerGame[] Games { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("verified")]
        public bool? Verified { get; set; }
    }
}