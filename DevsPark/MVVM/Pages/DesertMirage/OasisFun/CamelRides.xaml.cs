using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.DesertMirage.OasisFun;

public partial class CamelRides : ContentPage
{
    public CamelRides(PlacesViewModel vm)
    {
        InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}