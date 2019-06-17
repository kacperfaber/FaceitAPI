using FaceitAPI.Models;
using Newtonsoft.Json;

namespace FaceitAPI.Interfaces
{
    public class ChampionshipMatches
    {
        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("items")]
        public Match[] Items{ get; set; }
    }
}