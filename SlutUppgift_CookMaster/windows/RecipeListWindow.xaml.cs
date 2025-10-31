using SlutUppgift_CookMaster.windows;
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

namespace SlutUppgift_CookMaster
{
    /// <summary>
    /// Interaction logic for RecipeListWindow.xaml
    /// </summary>
    public partial class RecipeListWindow : Window, INotifyPropertyChanged
    {
        public RecipeListWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            this.Close();
            addRecipeWindow.Show();
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            RecipeDetailWindow recipeDetailWindow = new RecipeDetailWindow();
            this.Close();
            recipeDetailWindow.Show();

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            UserDetailsWindow userDetailsWindow = new UserDetailsWindow();
            this.Close();
            userDetailsWindow.Show();
        }
    }
}
