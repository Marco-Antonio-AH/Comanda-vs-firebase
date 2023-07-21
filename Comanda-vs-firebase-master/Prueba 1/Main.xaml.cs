namespace Prueba_1;

public partial class MainPage : ContentPage
{

    private string strAuthentifyUser;
    public static string sstrEmailUser;
    LoginAccess OAuthLogin = new LoginAccess(sstrEmailUser);

    public MainPage()
    {

        InitializeComponent();
        //prueba.Text = Preferences.Default.Get("keyEmail", "") + "  " + Preferences.Default.Get("IsLoggedIn", false).ToString() + " " + OAuthLogin.isLogin();
        comprobarLogin();

    }



    private async void comprobarLogin()
    {
        await Task.Delay(3000);

        if (OAuthLogin.isLogin())
        {
            IrAMenu();
        }
        else
        {
            IrAlLogin();
        }


    }

    private async void IrAlLogin()
    {
        // Espera 3 segundos
        //Application.Current.MainPage = new Login();

        await Application.Current.MainPage.Navigation.PushAsync(new Login());

        //await Navigation.PushModalAsync(new Login());

        //Login = new NavigationPage(new Login());


    }

    private async void IrAMenu()
    {

        await Application.Current.MainPage.Navigation.PushAsync(new Menu());
        //await Navigation.PushAsync(new Menu());


    }
}