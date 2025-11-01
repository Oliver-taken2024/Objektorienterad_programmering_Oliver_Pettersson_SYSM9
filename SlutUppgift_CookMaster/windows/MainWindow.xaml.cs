using SlutUppgift_CookMaster.Manager;
using SlutUppgift_CookMaster.Users;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Formats.Asn1.AsnWriter;

namespace SlutUppgift_CookMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        public UserManager UserManager { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;
            UserManager = (UserManager)Application.Current.Resources["UserManager"];
        }
        private string _userNameInput = "UserName";
       public string UserNameInput// jag binder denna till en textbox
        {
            get { return _userNameInput; }
            set { _userNameInput = value; OnPropertyChanged(); }
        }

        private string _passwordInput = "Password";
        public string PasswordInput//samma här binder den till andra textbox
        {
            get { return _passwordInput; }
            set { _passwordInput = value; OnPropertyChanged(); }
        }
        private void Login_Click(object sender, RoutedEventArgs e) //gör denna sist för jag behöver ha skapat RecipeWindow 
        {
            Login();
            
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            OpenRegister();
        }


        public void Login()//När denna metod är klar ska MainWindow stängas och RecipeListWindow öppnas
        {
            
            bool v =UserManager.Login(UserNameInput, PasswordInput);
            RecipeListWindow recipeListWindow = new RecipeListWindow();
            if (v == true)
            {
                foreach(var user in UserManager.Users)
                {
                    if (UserNameInput == user.UserName)
                    {
                        UserManager.GetLoggedIn(user); 
                    }
                }
                recipeListWindow.Show();
                recipeListWindow.ShowRecipe();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Du har antingen skrivit fel andvändar namn eller fel Lösenord"); 
            }
        }

        public void OpenRegister()// är till för att öppna RegisterWindow och stänga MainWindow
        {

            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        

       
    }
}