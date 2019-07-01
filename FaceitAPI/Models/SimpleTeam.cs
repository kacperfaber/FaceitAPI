using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class SimpleTeam
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("chat_room_id")]
        public string ChatRoomId { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("verified")]
        public bool? Verified { get; set; }
    }
}
