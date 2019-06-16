using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class JoinChecks
    {
        [JsonProperty("allowed_team_types")]
        public string[] AllowedTeamTypes { get; set; }

        [JsonProperty("blacklist_geo_countries")]
        public string BlacklistGeoCountries { get; set; }

        [JsonProperty("whitelist_geo_countries")]
        public string[] WhitelistGeoCountries { get; set; }

        [JsonProperty("join_policy")]
        public string JoinPolicy { get; set; }

        [JsonProperty("max_skill_level")]
        public int MaxSkillLevel { get; set; }

        [JsonProperty("membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty("whitelist_geo_countries_min_players")]
        public int WhitelistGeoCountriesMinPlayers { get; set; }
    }
}