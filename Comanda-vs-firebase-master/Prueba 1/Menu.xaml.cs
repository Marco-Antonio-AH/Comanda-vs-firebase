namespace Prueba_1;

public partial class Menu : ContentPage
{


    private string strAuthentifyUser;
    public static string sstrEmailUser;
    LoginAccess OAuthLogin = new LoginAccess(sstrEmailUser);


    public Menu()
    {
        strAuthentifyUser = OAuthLogin.AuthentifyLogin();
        InitializeComponent();

        actualizar();

        NavigationPage.SetHasNavigationBar(this, false);
    }

    void Logout(object sender, EventArgs e)
    {

        OAuthLogin.LogoutLogin();

        IrAlLogin();
        //actualizar();
    }

    private async void IrAlLogin()
    {
        //await Task.Delay(3000); // Espera 3 segundos
        //Application.Current.MainPage = new Login();

        await Application.Current.MainPage.Navigation.PushAsync(new Login());

        //await Navigation.PushModalAsync(new Login());

        //Login = new NavigationPage(new Login());


    }

    void actualizar()
    {
        //bienvenida.Text = "Bienvenid@ " + OAuthLogin.AuthentifyLogin() + Preferences.Default.Get("IsLoggedIn", false).ToString();
        bienvenida.Text = "Bienvenid@ " + OAuthLogin.AuthentifyLogin();
    }

}