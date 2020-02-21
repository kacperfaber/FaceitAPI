using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleMember
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }
}