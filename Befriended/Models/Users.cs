namespace Befriended.Droid.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User() { }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;

        }

        public bool VerifyUser()
        {
            if (!username.Equals(" ") && !password.Equals(" "))
            {
                return true;
            }
            else
            { 
                return false;
             }      
        }
    }
}