namespace Prueba_1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//Preferences.Default.Set("IsLoggedIn", false);

		MainPage = new AppShell();
	}
}
