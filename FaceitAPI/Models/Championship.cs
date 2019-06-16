using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Championship
    {
        [JsonProperty("anticheat_required")]
        public bool AntiCheatRequired { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }

        [JsonProperty("championship_id")]
        public string ChampsionshipId { get; set; }

        [JsonProperty("checkin_clear")]
        public int CheckinClear { get; set; }

        [JsonProperty("checkin_enabled")]
        public bool CheckinEnabled { get; set; }

        [JsonProperty("checkin_start")]
        public int CheckinStart { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("current_subscriptions")]
        public int CurrentSubscription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("full")]
        public bool Full { get; set; }

        [JsonProperty("game_data")]
        public GameData GameData { get; set; }

        [JsonProperty("join_checks")]
        public JoinChecks JoinChecks { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizer_data")]
        public OrganizerData OrganizerData { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("rules_id")]
        public string RulesId { get; set; }

        [JsonProperty("seeding_strategy")]
        public string SeedingStrategy { get; set; }

        [JsonProperty("slots")]
        public int Slots { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subscription_end")]
        public int SubscriptionEnd { get; set; }

        [JsonProperty("subscription_start")]
        public int SubscriptionStart { get; set; }

        [JsonProperty("subscription_locked")]
        public bool SubscriptionLocked { get; set; }

        [JsonProperty("total_groups")]
        public int TotalGroups { get; set; }

        [JsonProperty("total_rounds")]
        public int TotalRounds { get; set; }

        [JsonProperty("subsitutions_configuration")]
        public SubstitutionConfiguration SubstitutionConfiguration { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
