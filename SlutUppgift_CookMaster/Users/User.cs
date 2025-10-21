using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.User
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

        public void ValidateLogin()
        {

        }

        public void ChangePassword()
        {

        }

        public void UpdateDetails()
        {

        }

    }
}
