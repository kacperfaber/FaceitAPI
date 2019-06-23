using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Tournaments
    {
        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("items")]
        public Tournament[] Items { get; set; }
    }
}