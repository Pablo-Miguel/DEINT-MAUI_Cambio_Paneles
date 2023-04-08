namespace DEINT_MAUI_Cambio_Paneles;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}
}