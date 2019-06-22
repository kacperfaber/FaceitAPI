using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class ChampionshipMember
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty("memberships")]
        public string[] Memberships { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}