using Prosper.MVVM.ViewModels;

namespace Prosper.MVVM.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;
        BindingContext = new DashboardViewModel();
    }

    private async void addTransaction_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TransactionPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (DashboardViewModel)BindingContext;
        vm.FillData();
    }
}