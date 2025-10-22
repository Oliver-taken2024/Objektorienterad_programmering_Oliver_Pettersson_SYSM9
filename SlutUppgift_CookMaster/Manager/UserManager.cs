using SlutUppgift_CookMaster.Users;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.Manager
{
    public class UserManager
    {
        public ObservableCollection<User> users { get; set; } = new();

        public User Loggedin;

        public bool Login(string u, string p) 
        { 
            return true;
        }

        public void Register(string u, string p, string c) 
        {

        }

        public void FindUser(string Name)
        {

        }

        public void ChangePassword()
        {

        }

        public User GetLoggedIn()
        {
            return users[0];
        }


    }
}
