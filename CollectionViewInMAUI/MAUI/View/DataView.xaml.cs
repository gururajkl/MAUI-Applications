namespace CollectionViewInMAUI.MAUI.View;

public partial class DataView : ContentPage
{
    public DataView()
    {
        InitializeComponent();
    }

    private void GotToNavPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LayoutPage());
    }
}