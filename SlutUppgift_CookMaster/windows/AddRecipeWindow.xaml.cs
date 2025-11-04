using SlutUppgift_CookMaster.Manager;
using SlutUppgift_CookMaster.Recipes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for AddRecipeWindow.xaml
    /// </summary>
    public partial class AddRecipeWindow : Window, INotifyPropertyChanged
    {
        DateTime Currenttime = DateTime.Now;
        public RecipeManager Recipes { get; private set; }
        public Recipe recipe;
        public UserManager UserManager;
        
        public AddRecipeWindow()
        {
            InitializeComponent();
            DataContext= this;
            Recipes = (RecipeManager)Application.Current.Resources["RecipeManager"];
            UserManager = (UserManager)Application.Current.Resources["UserManager"];
        }
        private string _titleInput { get; set; }
        public string TitleInput
        {
            get { return _titleInput; }
            set { _titleInput = value; OnPropertyChanged(); }
        }

        private string _ingrediantsInput { get; set; }
        public string IngrediantsInput 
        {
            get { return _ingrediantsInput; } 
            set{ _ingrediantsInput = value; OnPropertyChanged();}
        }

        private string _instructionInput { get; set; }
        public string InstructionInput
        {
            get { return _instructionInput; }
            set { _instructionInput = value; OnPropertyChanged(); }
        }

        private string _catagoryInput { get; set; }
        public string CatagoryInput 
        { 
            get { return _catagoryInput; } 
            set { _catagoryInput = value;OnPropertyChanged();}
        }



        private void Add_Click(object sender, RoutedEventArgs e)// add recipes
        {
            if (TitleInput != null && IngrediantsInput != null && InstructionInput != null && CatagoryInput != null)
            {
                RecipeListWindow recipeListWindow = new RecipeListWindow();
                recipe = new Recipe(TitleInput, IngrediantsInput, InstructionInput, CatagoryInput, Currenttime, UserManager.Loggedin);
                Recipes.AddRecipe(recipe);
                this.Close();
                recipeListWindow.ShowRecipe();
                recipeListWindow.Show();
            }
            else
            {
                MessageBox.Show("Du måste fylla in alla rutor");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
