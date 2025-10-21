using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.User
{
    public class AdminUser : User
    {
        public AdminUser(string username, string password, string country) : base(username, password, country)
        {
        }

        public void RemoveAnyRecipe()
        {

        }

        public void ViewAllRecipes()
        {

        }
    }
}
