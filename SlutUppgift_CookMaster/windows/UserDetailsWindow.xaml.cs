using SlutUppgift_CookMaster.Manager;
using SlutUppgift_CookMaster.Users;
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
    /// Interaction logic for UserDetailsWindow.xaml
    /// </summary>
    public partial class UserDetailsWindow : Window, INotifyPropertyChanged
    {
        public UserManager UserManager;
        public UserDetailsWindow()
        {
            InitializeComponent();
            DataContext = this;
            UserManager = (UserManager)Application.Current.Resources["UserManager"];
        }
        
        public User Loggedin
        {
            get
            {
                return UserManager.Loggedin;
            }
            private set
            {
                UserManager.Loggedin = value;

            }
        }

        public void ShowUser ()
        {
            Username.Text= Loggedin.UserName;
        }

      

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            RecipeListWindow recipeListWindow = new RecipeListWindow();
            User user = new User();
            recipeListWindow.Show();

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

            RecipeListWindow recipeListWindow = new RecipeListWindow();
            recipeListWindow.Show();
            recipeListWindow.ShowRecipe();
            this.Close();
        }
    }
}
