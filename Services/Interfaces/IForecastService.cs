using RainProbably.Models.APP.Weather;

namespace RainProbably.Services.Interfaces
{
    public interface IForecastService
    {
        public Response Get();
    }
}