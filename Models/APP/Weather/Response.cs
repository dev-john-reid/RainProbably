using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RainProbably.Models.APP.Weather
{
    public class Response
    {
        public Response()
        {
            Weather = new List<Forecast>();
        }
        public List<Forecast> Weather { get; set; }
    }
}
