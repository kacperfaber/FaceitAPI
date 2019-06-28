using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleOrganizer
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("countries")]
        public string[] Countries { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("partner")]
        public bool Partner { get; set; }

        [JsonProperty("regions")]
        public string[] Regions { get; set; }
    }
}
