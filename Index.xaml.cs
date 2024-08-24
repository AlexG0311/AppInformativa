namespace AppInformativa;

public partial class Index : FlyoutPage
{
	public Index()
	{
		InitializeComponent();
		Flyout = new Maestro();
        Detail =  new NavigationPage(new Detalle());
		App.FlyoutPage = this;
	}
}