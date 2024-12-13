using Pogoda.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Pogoda.Resurses.Converters
{
    internal class WeatherCodesToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var recorceName = "/Resurses/icons/Weather/TypeOfWeather/";
            switch ((WeatherCodes)value)
            {
                case WeatherCodes.ClearSky:
                    return recorceName += "ClearSky.png";
                case WeatherCodes.Windy:
                    return recorceName += "Windy.png";
                case WeatherCodes.Overcast:
                    return recorceName += "Overcast.png";
                case WeatherCodes.Fog:
                    return recorceName += "Fog.png";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
