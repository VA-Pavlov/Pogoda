using Pogoda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pogoda.ViewModels
{
    public partial class HomeViewViewModel : INotifyPropertyChanged
    {
        private List<DayForecastModel> forecastDays;
        public List<DayForecastModel> ForecastDays
        {
            get { return forecastDays; }
            set
            {
                forecastDays = value;
                OnPropertyCanged();
            }
        }
        private DayForecastModel selectedDay;
        public DayForecastModel SelectedDay
        {
            get { return selectedDay; }
            set
            {
                selectedDay = value;
                OnPropertyCanged();
            }
        }
        public HomeViewViewModel()
        {
            var data = new DayForecastModel()
            {
                Date = DateTime.Now.ToString(),
                WeekDay = DateTime.Today.ToString(),
                MaxTemperature = 15,
                MinTemperature = 0,
                Location = "Pitsburg",
                Wheather = WeatherCodes.Windy,
                Pressure = 3.4F,
                WindDirection = WindDirection.East,
                HourlyForecasts = new List<HourlyForecastModel>() {
                    new HourlyForecastModel() { Time = DateTime.Now, RelativeHumidity = 1.5f},
                    new HourlyForecastModel() { Time = DateTime.Now, RelativeHumidity = 1.6f}

                }
            };
            forecastDays = new List<DayForecastModel>() { data,data,data, data };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyCanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
