using System.Windows;
using System.Windows.Controls;

namespace MichelMichels.WeatherApp;

public class DayForecastThumbnail : Control
{
    public static readonly DependencyProperty DateProperty =
        DependencyProperty.Register(
            nameof(Date),
            typeof(DateOnly),
            typeof(DayForecastThumbnail),
            new PropertyMetadata(DateOnly.MinValue));

    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register(
            nameof(CornerRadius),
            typeof(CornerRadius),
            typeof(DayForecastThumbnail),
            new PropertyMetadata(new CornerRadius(0)));

    static DayForecastThumbnail()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(DayForecastThumbnail),
            new FrameworkPropertyMetadata(typeof(DayForecastThumbnail)));
    }

    public DateOnly Date
    {
        get => (DateOnly)GetValue(DateProperty);
        set => SetValue(DateProperty, value);
    }
    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

}
