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
        public ObservableCollection<Recipe> Recipes {  get; set; }
        public UserManager UserManager { get; set; }

        

        public RecipeManager() 
        {
            Recipes = new ObservableCollection<Recipe>();
            Recipes.Add(new Recipe("Fish and chips", "fish, potato", "Slice the potatos into four piece. " +
                "then cook the fish in the meantime put the sliced potatos in the oven and put the timer to 10 minutes or until the potatos has yellow brown coler on them.",
                "Brithish food",new DateTime (2025,10,31)));
            Recipes.Add(new Recipe("Hotdog", "Hotdog, bread and ketchup", "Put the hot dog on the grill for about 5 minutes then take it of the grill put it on the bread then put ketchup on"
                , "Fastfood", new DateTime(2025,10 ,31)));
        }

        public void AddRecipe(Recipe r) // lägger till ett recept till listan
        {
            Recipes.Add(r);
        }

        public void RemoveRecipe(Recipe r)// tar bort ett recept från listan genom att söka genom listan efter en titel som matchar
        {
            foreach (var item in Recipes) 
            {
                if (item.Title == r.Title) 
                {
                    Recipes.Remove(item);
                    break;
                }
            }
        }

        public void GetAllRecipe()// kan göra så att bara userna kan se sina egna recept listor genom att göra så att jag gör en metod som letar igenom listan efter recept som har usernamnet inskrivet i det 
        {

        }

        public void GetByUser(User u)
        {
            

        }

        
    }
}
