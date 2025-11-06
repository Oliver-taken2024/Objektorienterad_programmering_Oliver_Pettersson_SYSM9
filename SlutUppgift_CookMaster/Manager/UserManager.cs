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
        public ObservableCollection<User> Users { get; set; }

        public UserManager()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User("user","password","Sweden"));
            Users.Add(new User("admin","password","Sweden"));
        }

        public User Loggedin;
      

        public bool Login(string u, string p) // kollar listan om det finns en User med samma namn och lösenord om det finns ska den returna true annars ska den returna false
        {
            bool login = false;
            foreach (var user in Users) 
            {
                if (user.Password == p && user.UserName==u) 
                { 
                    login = true;
                    Loggedin = user;
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
            Users.Add(new User(u,p,c));
        }

        public bool FindUser(string Name)// Ska hitta en user dock vet jag inte för studen varför detta skulle behövas men jag kommer förmodligen att komma på det senare
        {
            foreach (var user in Users) 
            {
                if (user.UserName == Name)
                {
                    return true;
                }
                
            } 
            return false;
        }

        public void ChangeProfile(string u, string p, string c)//Ska ändra Userns namn och lösenord
        {
            User user = new User(u,p,c);
            for (int i = 0; i < Users.Count; i++) 
            {
                if (Users[i].UserName == Loggedin.UserName)
                {
                     GetLoggedIn(user);
                     Users[i] = user;
                     break;
                }
            }

        }

        public User GetLoggedIn(User m) // ändra vilken user det är som använder programet
        {
            Loggedin = m;
            return Loggedin;
        }


    }
}
