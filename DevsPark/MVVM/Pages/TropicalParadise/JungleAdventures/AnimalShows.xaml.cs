using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.TropicalParadise.JungleAdventures;

public partial class AnimalShows : ContentPage
{
    public AnimalShows(PlacesViewModel vm)
    {
        InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}