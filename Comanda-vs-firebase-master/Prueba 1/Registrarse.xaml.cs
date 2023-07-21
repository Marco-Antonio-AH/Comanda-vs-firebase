using FireSharp.Interfaces;
using FireSharp.Response;


namespace Prueba_1;


public partial class Registrarse : ContentPage
{

    IFirebaseClient client;
    public Registrarse()
    {
        InitializeComponent();
        client = new FireSharp.FirebaseClient(conexion.Config);
    }

    public async void registrarUsuario(object sender, EventArgs e)
    {

        var User = new User
        {
            Nombre = registroNombre.Text,
            Contraseña = registroContraseña.Text
        };
        PushResponse response = await client.PushAsync("Usuarios", User);
        User result = response.ResultAs<User>(); //The response will contain the data written
    }
}