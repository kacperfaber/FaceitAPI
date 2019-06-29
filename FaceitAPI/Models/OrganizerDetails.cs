using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class OrganizerDetails
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("faceit_url")]
        public string  FaceitUrl { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("twitch")]
        public string Twitch { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("vk")]
        public string Vk { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("youtube")]
        public string Youtube { get; set; }
    }
}