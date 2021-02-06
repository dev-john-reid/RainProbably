using RainProbably.Models.API.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RainProbably.Models.APP.Weather
{
    public class Forecast
    {
        public Forecast(ConsolidatedWeather w)
        {
            Date = w.ApplicableDate;
            State = w.WeatherStateName;
            ImgUrl = string.Concat("https://www.metaweather.com/static/img/weather/png/", w.WeatherStateAbbr, ".png");
        }
        public string Date { get; set; }
        public string State { get; set; }
        public string ImgUrl { get; set; }
    }
}
