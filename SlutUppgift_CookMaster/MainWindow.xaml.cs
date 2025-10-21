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
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;
        }
        private string _userNameInput;
       public string UserNameInput// jag binder denna till en textbox
        {
            get { return _userNameInput; }
            set { _userNameInput = value; OnPropertyChanged(); }
        }

        private string _passwordInput;
        public string PasswordInput//samma här binder den till andra textbox
        {
            get { return _passwordInput; }
            set { _passwordInput = value; OnPropertyChanged(); }
        }


        public void Login()//När denna metod är klar ska MainWindow stängas och RecipeListWindow öppnas
        {

        }

        public void OpenRegister()// är till för att öppna RegisterWindow och stänga MainWindow
        {

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}