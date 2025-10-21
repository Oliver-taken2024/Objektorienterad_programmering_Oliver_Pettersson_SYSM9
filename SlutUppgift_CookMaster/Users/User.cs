using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.Users
{
    public abstract class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }

        public User(string username, string password, string country)
        {
            UserName = username;
            Password = password;
            Country = country;
        }


        public void ValidateLogin()//ser till at lössenordet är samma som användaren skriver in
        {//Kanske lägga till en if som ser om användarens input är samma som lössenordet

        }

        public void ChangePassword()//Kan ändra lössenordet
        {

        }

        public void UpdateDetails()//Uppdaterar Users list i UserManager tror jag
        {

        }
    }
}
