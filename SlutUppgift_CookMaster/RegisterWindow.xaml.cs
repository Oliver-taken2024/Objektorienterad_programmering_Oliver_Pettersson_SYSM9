using SlutUppgift_CookMaster.Manager;
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

namespace SlutUppgift_CookMaster
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window, INotifyPropertyChanged
    {
        public UserManager UserManager { get; private set; }
        public RegisterWindow()
        {
            InitializeComponent();
            DataContext = this;
            UserManager = (UserManager)Application.Current.Resources["UserManager"];
            
        }
        

        private string _usernameInput = "Username";

        public string UserNameInput
        {
            get { return _usernameInput; }
            set { _usernameInput = value; OnPropertyChanged(); }
        }

        private string _passwordInput = "Password";
        public string PasswordInput
        {
            get { return _passwordInput; }
            set { _passwordInput = value; OnPropertyChanged(); }
        }

        public List<string> Countries { get; set; } = new() { "Sweden", "Norway", "Finland", "Denmark"};

        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; OnPropertyChanged(); }
        }


        public void CreateUser()//ska lägga till en ny user i users Listan
        {
            
            UserManager.Register(UserNameInput, PasswordInput, Country);
        }

        public void ValidatePassword()// ska see till att lösenordet ska vara en viss länged kanske gör jag denna om jag har tid
        {

        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            CreateUser();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        
    }
}
