using System.Globalization;

namespace Weather.Converters
{
    public class CodeToWeatherConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            float code = (float)value;

            switch (code)
            {
                case 0:
                    return "Clear Sky";
                case 1:
                    return "Mainly Clear";

                case 2:
                    return "Partly Cloudy";

                case 3:
                    return "Overcast";

                case 45:
                    return "Fog";

                case 48:
                    return "Rime fog";

                case 51:
                    return "Light Drizzle";

                case 53:
                    return "Drizzle";

                case 55:
                    return "Drizzle";

                case 56:
                    return "Freezing Drizzle";

                case 57:
                    return "Freezing Drizzle";

                case 61:
                    return "Rain: Slight";

                case 63:
                    return "Rain: Moderate";

                case 65:
                    return "Rain";

                case 66:
                    return "Freezing Rain";

                case 67:
                    return "Freezing Rain";

                case 71:
                    return "Snow fall: Slight";

                case 73:
                    return "Snow fall: Moderate";

                case 75:
                    return "Snow fall";

                case 77:
                    return "Snow grains";

                case 80:
                    return "Rain showers: Slight";

                case 81:
                    return "Rain showers";

                case 82:
                    return "Rain showers";

                case 85:
                    return "Snow showers: Slight";

                case 86:
                    return "Snow showers: Heavy";

                case 95:
                    return "Thunderstorm";

                case 96:
                case 99:
                    return "Thunderstorm";

                default: return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
