using System.Globalization;

namespace Weather.Converters
{
    public class TitleCaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string title = value as string;
            if (title != null)
            {
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
