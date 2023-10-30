using Prosper.MVVM.ViewModels;

namespace Prosper.MVVM.Views;

public partial class TransactionPage : ContentPage
{
    public TransactionPage()
    {
        InitializeComponent();
        BindingContext = new TransactionViewModel();
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        var vm = (TransactionViewModel)BindingContext;
        var message = vm.SaveTransaction();
        await DisplayAlert("Info", message, "OK");
        await Navigation.PopToRootAsync();
    }

    private async void Cancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}