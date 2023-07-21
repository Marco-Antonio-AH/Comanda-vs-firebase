namespace Prueba_1
{
    public class LoginAccess
    {
        public static string sstrEmail = "";
        public static Boolean sstrLogin;
        public LoginAccess(string pstrEmailUser)
        {

            if (!string.IsNullOrEmpty(Preferences.Default.Get("keyEmail", "")))
            {
                var vKeyEmail = Preferences.Default.Get("keyEmail", "");
                sstrEmail = vKeyEmail;
                sstrLogin = true;
            }
        }
        public string AuthentifyLogin()
        {
            return sstrEmail;
        }

        public Boolean isLogin()
        {
            return sstrLogin;
        }

        public void LogoutLogin()
        {

            Preferences.Default.Remove("keyEmail");
            Preferences.Default.Set("IsLoggedIn", false);

            sstrLogin = false;
        }
    }
}
