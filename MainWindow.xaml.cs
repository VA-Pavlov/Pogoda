using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pogoda
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            WeatherDays_ListBox.ItemsSource = new List<DayForecastModel>() { data,data,data};
        }

        private void WeatherDayButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                var day = button.DataContext as DayForecastModel;
                Detals_StackPanel.DataContext = day;
                WeatherHours_ListBox.ItemsSource = day.HourlyForecasts;
            }
        }
    }
}
