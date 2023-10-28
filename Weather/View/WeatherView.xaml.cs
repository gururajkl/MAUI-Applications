namespace Weather.View;

public partial class WeatherView : ContentPage
{
    public WeatherView()
    {
        InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;
    }
}