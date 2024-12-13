using Pogoda.Models;
using Pogoda.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogoda.Data
{
    public static class DateDictionary
    {
        private static List<DayForecastModel> dateDictionary = new List<DayForecastModel>();

        public static List<DayForecastModel> GetDats()
        {
            if (dateDictionary.Count == 0)
            {
                Random random = new Random();
                DateTime today = DateTime.Today;
                    for (int i = -3; i <= 3; i++)
                    {
                        DateTime date = today.AddDays(i);
                        DayForecastModel forecast = new DayForecastModel
                        {
                            Date = date,
                            WeekDay = date.DayOfWeek.ToString(),
                            MaxTemperature = (float)random.Next(0, 30),
                            MinTemperature = (float)random.Next(-30, 5),
                            Pressure = (float)(1010 + i),
                            WindSpeed = (float)random.Next(0, 20),
                            WindDirection = WindDirection.East,
                            Wheather = i > random.Next(-3, 3) ? WeatherCodes.ClearSky : WeatherCodes.Overcast,
                            Location = "Москва",
                            HourlyForecasts = hourlyForecast()
                        };

                        dateDictionary.Add(forecast);
                    }
                }
                return dateDictionary;
            }

        private static List<HourlyForecastModel> hourlyForecast()
        {
            List<HourlyForecastModel> hourlyForecastList = new List<HourlyForecastModel>();
            Random random = new Random();
            for (int hour = 0; hour < 24; hour++)
            {
                DateTime time = DateTime.Today + new TimeSpan(hour, 0, 0);
                hourlyForecastList.Add(new HourlyForecastModel
                {
                    Time = time,
                    Temperature = (float)random.Next(-30, 30),
                    ApparentTemperature = random.Next(-30, 30),
                    RelativeHumidity = (float)random.Next(-30, 30),
                    SurfasePressure = (float)(1010 + (hour - 12) % 12),
                    WindSpeed = (float)random.Next(0,20),
                    WindDirection = hour > random.Next(1,11) ? WindDirection.West : WindDirection.Nord,
                    Weather = hour > random.Next(1, 15) ? WeatherCodes.ClearSky : WeatherCodes.Overcast
                });
            }
            return hourlyForecastList;
        }
    }
    }
