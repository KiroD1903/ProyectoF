namespace ProyectoFinal.Models
{
    public class Login
    {
        private string __username;
        private string __password;
        public string username
        {
            get { return __username; }
            set { __username = value; }
        }

        public string password
        {
            get
            {
                return __password;
            }
            set { __password = value; }
        }
    }
}