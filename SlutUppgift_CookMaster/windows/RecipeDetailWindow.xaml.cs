using SlutUppgift_CookMaster.Manager;
using SlutUppgift_CookMaster.Recipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SlutUppgift_CookMaster.windows
{
    /// <summary>
    /// Interaction logic for RecipeDetailWindow.xaml
    /// </summary>
    public partial class RecipeDetailWindow : Window, INotifyPropertyChanged
    {
        DateTime dateTime= DateTime.Now;
        public Recipe r;
        public RecipeManager recipeManager;
        public UserManager userManager;
        RecipeListWindow recipeListWindow = new RecipeListWindow();
        public RecipeDetailWindow(Recipe recipe)
        {
            Recipe = recipe;
            InitializeComponent();
            DataContext=this;
            Box1.Text = recipe.Title;
            Box2.Text = recipe.Ingredients;
            Box3.Text = recipe.Instructions;
            Box4.Text= recipe.Catagory;
            Box5.Text= $"{recipe.Date}";

            recipeManager = (RecipeManager)Application.Current.Resources["RecipeManager"];
            userManager = (UserManager)Application.Current.Resources["UserManager"];

        }

        private Recipe Recipe;
        
        

public event PropertyChangedEventHandler? PropertyChanged;

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Box1.IsEnabled = true;
            Box2.IsEnabled = true;
            Box3.IsEnabled = true;
            Box4.IsEnabled = true;
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(Box1.Text) &&
    !string.IsNullOrWhiteSpace(Box2.Text) &&
    !string.IsNullOrWhiteSpace(Box3.Text) &&
    !string.IsNullOrWhiteSpace(Box4.Text))
            {
                EditRecipe();
                recipeListWindow.ShowRecipe();
                this.Close();
                recipeListWindow.Show();
                
                
            }
            else
            {
                MessageBox.Show("Du måste fylla in alla boxarna");
            }
        }

        public void EditRecipe()// Ändrar receptet men gör så att inte alla recept som admin ser blir denns
        {
                r = new Recipe(Box1.Text, Box2.Text, Box3.Text, Box4.Text, dateTime, Recipe.CreatedBY);
                recipeManager.UppdateRecipe(r, Recipe);

           
        }
    }
}
