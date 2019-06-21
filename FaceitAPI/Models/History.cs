using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitAPI.Models
{
    // narazie probuje tak, wydaje mi sie on zwraca typ klasy match
    public class History
    {
        [JsonProperty("items")]
        public Match[] Matches { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }
    }
}