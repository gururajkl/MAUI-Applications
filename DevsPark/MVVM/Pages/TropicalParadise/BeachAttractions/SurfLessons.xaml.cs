using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.TropicalParadise.BeachAttractions;

public partial class SurfLessons : ContentPage
{
    public SurfLessons(PlacesViewModel vm)
    {
        InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}