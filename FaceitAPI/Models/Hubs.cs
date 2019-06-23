using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Hubs
    {
        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("items")]
        public Hub[] Items { get; set; }
    }
}