using System.Globalization;
using System.Windows.Data;

namespace MichelMichels.WeatherApp.Converters;

public class DateOnlyDayNameConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not DateOnly dateOnly)
        {
            return string.Empty;
        }

        if (dateOnly.ToDateTime(TimeOnly.MinValue).Equals(DateTime.Today))
        {
            return "Today";
        }

        return dateOnly.ToString("ddd");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
