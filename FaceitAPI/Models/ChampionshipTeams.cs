using FaceitAPI.Interfaces;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleChampionshipTeams
    {
        [JsonProperty("faction1")]
        public SimpleChampionshipTeam TeamA { get; set; }

        [Newtonsoft.Json.JsonProperty("faction2")]
        public SimpleChampionshipTeam TeamB { get; set; }
    }
}