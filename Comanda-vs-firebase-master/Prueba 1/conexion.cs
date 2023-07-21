using FireSharp.Config;
using FireSharp.Interfaces;

namespace Prueba_1
{
    public class conexion
    {
        public static IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "CWPQtVbTPS3LAhu2JzWrN937ZK0PDqHxUWmJlmPp",
            BasePath = "https://comanda-movil-default-rtdb.firebaseio.com/"
        };
    }
}
