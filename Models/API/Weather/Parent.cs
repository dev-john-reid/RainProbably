using Newtonsoft.Json;

namespace RainProbably.Models.API.Weather
{
    public class Parent
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        [JsonProperty("woeid")]
        public int Woeid { get; set; }

        [JsonProperty("latt_long")]
        public string LattLong { get; set; }
    }
}