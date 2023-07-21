namespace Prueba_1;

using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Maui.Controls;
using System;

public partial class Login : ContentPage
{
    int count = 0;

    IFirebaseClient client;

    public Login()
    {
        InitializeComponent();
        //MainPage = new NavigationPage(new MyContentPage());
        client = new FireSharp.FirebaseClient(conexion.Config);


    }



    public async void obtenerPrimerUsuario()
    {
        FirebaseResponse response = await client.GetAsync("Usuarios/user1");
        User obj = response.ResultAs<User>();

        textoInicial.Text = $"Bienvenido {obj.Nombre}";
    }


    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        string nombre = nombreEntry.Text;
        string contraseña = contraseñaEntry.Text;

        var response = await client.GetAsync("Usuarios");
        Dictionary<string, User> usuarios = response.ResultAs<Dictionary<string, User>>();

        foreach (KeyValuePair<string, User> usuario in usuarios)
        {
            if (usuario.Value.Nombre == nombre && usuario.Value.Contraseña == contraseña)
            {
                // Usuario encontrado
                comprobacion();

                break;
            }
            else
            {
                comprobacion_no_encontro();
            }
        }

    }

    void comprobacion()
    {
        textoInicial.Text = "Inicio Correcto";
        Preferences.Default.Set("keyEmail", nombreEntry.Text);
        Preferences.Default.Set("IsLoggedIn", true);

        IrAMenu();

    }

    void comprobacion_no_encontro()
    {
        textoInicial.Text = "Datos incorrectos";
    }

    async void IrARegistrarse(object sender, EventArgs e)
    {


        await Navigation.PushAsync(new Registrarse());


    }

    async void IrAMenu()
    {

        await Application.Current.MainPage.Navigation.PushAsync(new Menu());
        //await Navigation.PushAsync(new Menu());


    }


}
