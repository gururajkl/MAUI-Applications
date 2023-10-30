using Prosper.MVVM.Models;

namespace Prosper.MVVM.ViewModels
{
    public class TransactionViewModel
    {
        public Transaction Transaction { get; set; } = new Transaction { OperationDate = DateTime.Now };

        public string SaveTransaction()
        {
            App.TransactionRepository.SaveItem(Transaction);
            return App.TransactionRepository.StatusMessage;
        }
    }
}
