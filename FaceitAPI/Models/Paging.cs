using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Paging <TYPE>
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("items")]
        public TYPE[] Items { get; set; }
    }
}