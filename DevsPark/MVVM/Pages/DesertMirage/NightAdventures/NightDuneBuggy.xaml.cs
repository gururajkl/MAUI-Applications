using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.DesertMirage.NightAdventures;

public partial class NightDuneBuggy : ContentPage
{
    public NightDuneBuggy(PlacesViewModel vm)
    {
        InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}