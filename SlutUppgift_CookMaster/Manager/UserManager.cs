using SlutUppgift_CookMaster.Users;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.Manager
{
    public class UserManager 
    {
        public ObservableCollection<User> users { get; set; }

        public UserManager()
        {
            users = new ObservableCollection<User>();
            users.Add(new User("User","Password","Sweden"));
            users.Add(new User("Admin","Password","Sweden"));
        }

        public User Loggedin;

        public bool Login(string u, string p) // kollar listan om det finns en User med samma namn och lösenord om det finns ska den returna true annars ska den returna false
        {
            bool login = false;
            foreach (var user in users) 
            {
                if (user.Password == p && user.UserName==u) 
                { 
                    login = true;
                    return login;
                }
                else
                {
                  login= false;
                }
            }

            return login;
        }

        public void Register(string u, string p, string c) // lägger till en ny user i Listan
        {
            users.Add(new User(u,p,c));
        }

        public void FindUser(string Name)// Ska hitta en user dock vet jag inte för studen varför detta skulle behövas men jag kommer förmodligen att komma på det senare
        {
            foreach (var user in users) 
            {
                if (user.UserName == Name)
                {

                }
            } 
        }

        public void ChangePassword()//Ska ändra lösenord kommer förmodligen använda Delet och sen add
        {

        }

        public User GetLoggedIn() // vet inte vad det här är till för?
        {
            return users[0];
        }


    }
}
