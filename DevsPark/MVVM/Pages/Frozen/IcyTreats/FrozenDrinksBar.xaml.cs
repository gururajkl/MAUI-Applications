using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.Frozen.IcyTreats;

public partial class FrozenDrinksBar : ContentPage
{
    public FrozenDrinksBar(PlacesViewModel vm)
    {
        InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}