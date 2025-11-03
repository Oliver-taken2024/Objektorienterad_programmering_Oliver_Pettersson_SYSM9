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
        public RecipeManager recipeManager;
        public RecipeDetailWindow()
        {
            InitializeComponent();
            DataContext=this;
            recipeManager = (RecipeManager)Application.Current.Resources["RecipeManager"];
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Box1.IsEnabled = true;
            Box2.IsEnabled = true;
            Box3.IsEnabled = true;
            Box4.IsEnabled = true;
            Box5.IsEnabled = true;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            RecipeListWindow recipeListWindow = new RecipeListWindow();
            EditRecipe();
            //this.Close();
            //recipeListWindow.Show();
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

        }
    }
}
