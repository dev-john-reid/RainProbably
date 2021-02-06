using RainProbably.Models.APP.Weather;
using RainProbably.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RainProbably.Services
{
    public class ForecastService : IForecastService
    {
        private IRestService _restService { get; set; }

        public ForecastService(IRestService restService)
        {
            _restService = restService;
        }

        public Response Get()
        {
            Response res = null;
            var root = _restService.Get();
            if (root != null)
            {
                res = new Response();
                // remove today's weather as we only want the 'next 5 days' (this datetime parse is a bit risky but safer than just removing element 0)
                var dailyForecasts = root.ConsolidatedWeather.Where(x => DateTime.Parse(x.ApplicableDate).Date != DateTime.Today.Date);
                // Convert to result objects
                res.Weather = dailyForecasts.Select(x => new Forecast(x)).ToList();
            }
            return res;
        }
    }
}
