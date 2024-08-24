namespace AppInformativa;

public partial class Maestro : ContentPage
{
	public Maestro()
	{
		InitializeComponent();
	}

    private void irApagina1(object sender, EventArgs e)
    {
        NavigationToPage(new Page1());
    }

    private void irApagina2(object sender, EventArgs e)
    {
        NavigationToPage(new Page2());
    }

    private void irApagina3(object sender, EventArgs e)
    {
        NavigationToPage(new Page3());
    }
    private void irApagina4(object sender, EventArgs e)
    {
        NavigationToPage(new Page4());
    }

    private void NavigationToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented=true;
    }
}