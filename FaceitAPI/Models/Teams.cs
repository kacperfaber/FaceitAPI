using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Teams
    {
        [JsonProperty("faction1")]
        public Team TeamA { get; set; }

        [JsonProperty("faction2")]
        public Team TeamB { get; set; }
    }
}