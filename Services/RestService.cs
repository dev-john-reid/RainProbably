using RainProbably.Models.API.Weather;
using RainProbably.Services.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RainProbably.Services
{
    public class RestService : IRestService
    {

        private readonly string Url = "https://www.metaweather.com/api/location/44544";

        public Root Get()
        {
            Root root = null;

            var client = new RestClient(Url);

            var req = new RestRequest(Method.GET);

            var response = client.Execute<Root>(req);

            if (response.IsSuccessful)
            {
                root = response.Data;
            }

            return root;
        }
    }
}
