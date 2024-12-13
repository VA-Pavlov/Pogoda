using Pogoda.Data;
using Pogoda.Models;
using System;
using System.Collections.Generic;

namespace Pogoda.ViewModels
{
    public class HomeViewViewModel : ViewModelBase
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
            forecastDays = DateDictionary.GetDats();
        }
    }
}
