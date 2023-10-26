using Tasker.MVVM.Views;

namespace Tasker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView());
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }
}