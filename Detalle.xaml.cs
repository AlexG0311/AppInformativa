namespace AppInformativa;

public partial class Detalle : ContentPage
{
	public Detalle()
	{
		InitializeComponent();

	}

    private void resumen(object sender, EventArgs e)
    {
		App.FlyoutPage.Detail.Navigation.PushAsync(new Resumen());

    }
}