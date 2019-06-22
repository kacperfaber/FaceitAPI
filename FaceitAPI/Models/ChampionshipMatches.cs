using FaceitAPI.Models;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class ChampionshipMatches
    {
        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("items")]
        public ChampionshipMatch[] Items{ get; set; }
    }
}