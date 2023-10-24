namespace StylesInMAUI;

public partial class DynamicView : ContentPage
{
	public DynamicView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Application.Current.Resources.TryGetValue("btnStyle", out var resBtn);

		Resources["dynamicBtn"] = (Style)resBtn;
    }
}