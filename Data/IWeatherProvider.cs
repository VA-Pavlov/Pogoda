using Pogoda.Models;
using System.Collections.Generic;

namespace Pogoda.Data
{
    public interface IWeatherProvider
    {
        List<DayForecastModel> GetDats();
    }
}