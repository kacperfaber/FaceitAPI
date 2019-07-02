using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class PlayerDetails
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bans")]
        public Ban[] Bans { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("cover_featured_image")]
        public string CoverFeaturedImage { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("friends_ids")]
        public string[] FriendsIds { get; set; }

        [JsonProperty("games")]
        [Obsolete("Pending edit.")]
        public Dictionary<string, object> Games { get; set; }

        [JsonProperty("infractions")]
        public Infractions Inractions { get; set; }

        [JsonProperty("membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty("memberships")]
        public string[] Memberships { get; set; }

        [JsonProperty("new_steam_id")]
        public string NewSteamId { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("platforms")]
        [Obsolete("pending edit.")]
        public Dictionary<string, object> Platforms { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("steam_id_64")]
        public string SteamId64 { get; set; }

        [JsonProperty("steam_nickname")]
        public string SteamNickname { get; set; }
    }
}
