﻿using Newtonsoft.Json;

namespace RainProbably.Models.API.Weather
{

    public class Source
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("crawl_rate")]
        public int CrawlRate { get; set; }
    }
}