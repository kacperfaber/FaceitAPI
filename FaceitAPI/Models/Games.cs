using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Games
    {
        [JsonProperty("csgo")]
        public CounterStrike CounterStrike { get; set; }
    }
}