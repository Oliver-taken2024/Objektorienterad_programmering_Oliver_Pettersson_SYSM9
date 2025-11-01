using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.Users
{
    public class AdminUser : User
    {
        public AdminUser(string username, string password, string country) : base(username, password, country)
        {
        }

        public void RemoveAnyRecipe()//Tar bort recipt från RecipeManager
        {

        }

        public void ViewAllRecipes()// kan se alla recept från alla användare
        {//foreach men söker inte efter user namn

        }
    }
}
