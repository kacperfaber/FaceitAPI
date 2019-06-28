using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimplePlayerGame
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("skill_level")]
        public string SkillLevel { get; set; }
    }
}