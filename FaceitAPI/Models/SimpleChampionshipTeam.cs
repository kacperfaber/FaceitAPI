using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleChampionshipTeam
    {
        [JsonProperty("faction_id")]
        public string Id { get; set; }

        [JsonProperty("leader")]
        public string Leader { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("roster")]
        public Roster[] Roster { get; set; }

        [JsonProperty("substituted")]
        public string Substituted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
