using Prosper.MVVM.Views;

namespace Prosper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StatisticsPage();
        }
    }
}