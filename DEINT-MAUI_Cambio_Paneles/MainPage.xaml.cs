namespace DEINT_MAUI_Cambio_Paneles;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ContentPageDemo());
	}
}

