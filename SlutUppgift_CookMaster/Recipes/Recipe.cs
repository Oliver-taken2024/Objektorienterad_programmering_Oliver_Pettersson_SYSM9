using SlutUppgift_CookMaster.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.Recipes
{
    public class Recipe
    {
        public string Title { get; set; }
        
        public string Ingredients { get; set; }

        public string Instructions { get; set; }

        public string Catagory { get; set; }

        public DateTime Date { get; set; }

        public User CreatedBY { get; set; }

        public void EditRecipe () 
        {

        }

        
    }
}
