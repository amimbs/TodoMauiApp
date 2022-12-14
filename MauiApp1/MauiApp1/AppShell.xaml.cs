namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// string and type of detailpage
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}
