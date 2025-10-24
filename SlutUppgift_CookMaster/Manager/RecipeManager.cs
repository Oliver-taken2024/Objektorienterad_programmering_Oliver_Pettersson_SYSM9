using SlutUppgift_CookMaster.Recipes;
using SlutUppgift_CookMaster.Users;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.Manager
{
    public class RecipeManager
    {
        public ObservableCollection<Recipe> recipes {  get; set; }

        public RecipeManager() 
        {
            recipes = new ObservableCollection<Recipe>();
        }

        public void AddRecipe(Recipe r)
        {
            
        }

        public void RemoveRecipe(Recipe r) 
        {
           
        }

        public void GetAllRecipe()
        {

        }

        public void GetByUser(User u)
        {

        }

        



    }
}
