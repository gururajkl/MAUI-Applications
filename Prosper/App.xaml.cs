using Prosper.MVVM.Models;
using Prosper.MVVM.Views;
using Prosper.Repositories;

namespace Prosper
{
    public partial class App : Application
    {
        public static BaseRepository<Transaction> TransactionRepository { get; private set; }

        public App(BaseRepository<Transaction> transactionRepository)
        {
            InitializeComponent();
            TransactionRepository = transactionRepository;

            MainPage = new NavigationPage(new DashboardPage());
        }
    }
}