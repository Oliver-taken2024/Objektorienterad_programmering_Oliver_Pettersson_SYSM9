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
        public RecipeDetailWindow()
        {
            InitializeComponent();
            DataContext=this;
            recipeManager = (RecipeManager)Application.Current.Resources["RecipeManager"];
        }

        //Skapa recipeDetails så jag kan använda den i recipemanager för att leta upp receptet  i listan för att sen ta bort det och lägga till ändringen

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
            RecipeListWindow recipeListWindow = new RecipeListWindow();
            if (!string.IsNullOrWhiteSpace(Box1.Text) &&
    !string.IsNullOrWhiteSpace(Box2.Text) &&
    !string.IsNullOrWhiteSpace(Box3.Text) &&
    !string.IsNullOrWhiteSpace(Box4.Text))
            {
                EditRecipe();
                this.Close();
                recipeListWindow.ShowRecipe();
                recipeListWindow.Show();
            }
            else
            {
                MessageBox.Show("Du måste fylla in alla boxarna");
            }
        }

        public void ShowRecipe(Recipe recipe)//visa hela recepted som man valde
        {
            
            Box1.Text = $"{recipe.Title}";
            Box2.Text = $"{recipe.Ingredients}";
            Box3.Text = $"{recipe.Instructions}";
            Box4.Text = $"{recipe.Catagory}";
            Box5.Text = $"{recipe.Date}";
        }

        public void EditRecipe()// will Change the recipe
        {
           
            r = new Recipe(Box1.Text, Box2.Text, Box3.Text, Box4.Text, dateTime);
            recipeManager.UppdateRecipe(r);
            
        }
    }
}
