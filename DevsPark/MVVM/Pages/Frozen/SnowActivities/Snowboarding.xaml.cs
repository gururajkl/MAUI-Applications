using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.Frozen.SnowActivities;

public partial class Snowboarding : ContentPage
{
    public Snowboarding(PlacesViewModel vm)
    {
        InitializeComponent();
        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}