using Pogoda.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Pogoda.ViewModels;

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
        }

        private void WeatherDayButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                var day = button.DataContext as DayForecastModel;
                //Detals_StackPanel.DataContext = day;
                //WeatherHours_ListBox.ItemsSource = day.HourlyForecasts;
            }
        }
    }
}
