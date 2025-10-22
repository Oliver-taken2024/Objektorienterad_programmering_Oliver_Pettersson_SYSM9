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
        public RegisterWindow()
        {
            InitializeComponent();
            DataContext = this;
            
        }

        private string _usernameInput;

        public string UserNameInput
        {
            get { return _usernameInput; }
            set { _usernameInput = value; OnPropertyChanged(); }
        }

        private string _passwordInput;
        public string PasswordInput
        {
            get { return _passwordInput; }
            set { _passwordInput = value; OnPropertyChanged(); }
        }

        public List<string> Countries { get; set; } = new() { "Sweden", "Norway", "Finland", "Denmark"};




        public void CreateUser()//ska lägga till en ny user i users Listan
        {

        }

        public void ValidatePassword()// ska see till att lösenordet ska vara en viss länged kanske gör jag denna om jag har tid
        {

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
