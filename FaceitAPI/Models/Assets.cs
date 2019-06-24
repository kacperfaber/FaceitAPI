using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    public class Assets
    {
        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("featured_img_l")]
        public string featuredImageL { get; set; }

        [JsonProperty("featured_img_m")]
        public string FeaturedImageM { get; set; }

        [JsonProperty("featured_img_s")]
        public string FeaturedImageS { get; set; }

        [JsonProperty("flag_img_icon")]
        public string FlagImageIcon { get; set; }

        [JsonProperty("flag_img_l")]
        public string FlagImageL { get; set; }

        [JsonProperty("flag_img_m")]
        public string FlagImageM { get; set; }

        [JsonProperty("flag_img_s")]
        public string FlagImageS { get; set; }

        [JsonProperty("landing_page")]
        public string LandingPage { get; set; }
    }
}