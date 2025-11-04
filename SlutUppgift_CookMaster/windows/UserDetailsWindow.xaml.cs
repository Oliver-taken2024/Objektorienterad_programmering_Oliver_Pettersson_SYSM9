using SlutUppgift_CookMaster.Manager;
using SlutUppgift_CookMaster.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private string _newUserName = $"NewUsername";
        public string NewUserName
        {
            get { return _newUserName; }
            set { _newUserName = value; OnPropertyChanged(); }
        }

        private string _newPassword= "NewPassword";
        public string NewPassword
        {
            get { return _newPassword; }
            set { _newPassword = value; OnPropertyChanged(); }
        }

        private string _confirmPassword= "ConfirmPassword";
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; OnPropertyChanged(); }
        }
        
     

        public List<string> Countries { get; set; } = new() { "Sweden", "Norway", "Finland", "Denmark" };

        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; OnPropertyChanged(); }
        }

        public bool CheckName(string name)
        { 
            bool result = false;
            foreach (var s in UserManager.Users) 
            {
                if (s.UserName == name)
                {
                    result = true; break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            RecipeListWindow recipeListWindow = new RecipeListWindow();
            bool result= CheckName(NewUserName);
            if (result == true)
            {
                MessageBox.Show("Detta Användarnamn är redan taget välj ett annat");

            }
            else
            {
                if (NewPassword == ConfirmPassword)
                {
                  UserManager.ChangeProfile(NewUserName, NewPassword, Country);
                  recipeListWindow.Show();
                  this.Close();
                }
                else
                {
                    MessageBox.Show("Du har inte skrivit rätt lössenord i båda rutorna");
                }
            }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

            RecipeListWindow recipeListWindow = new RecipeListWindow();
            recipeListWindow.Show();
            recipeListWindow.ShowRecipe();
            this.Close();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;
        

    }
}
