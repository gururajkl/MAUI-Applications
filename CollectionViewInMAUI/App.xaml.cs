using CollectionViewInMAUI.MAUI.View;

namespace CollectionViewInMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DataView());
        }
    }
}