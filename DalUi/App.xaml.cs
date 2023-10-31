using DalUi.Views;

namespace DalUi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GenerationOptionView();
        }
    }
}