using SlutUppgift_CookMaster.Manager;
using SlutUppgift_CookMaster.Recipes;
using SlutUppgift_CookMaster.Users;
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
        public UserManager UserManager;
        public RecipeManager recipeManager;
        public MainWindow mainWindow;

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
       

        public RecipeListWindow()
        {
            
            InitializeComponent();
            DataContext = this;
            recipeManager = (RecipeManager)Application.Current.Resources["RecipeManager"];
            UserManager = (UserManager)Application.Current.Resources["UserManager"]; 
        }
            
        private void AddRecipe_Click(object sender, RoutedEventArgs e)// gives me access to AddRecipeWindow
        {
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            this.Close();
            addRecipeWindow.Show();
        }

        private void Details_Click(object sender, RoutedEventArgs e)//ger mej tillgång till RecipeDetailsWindow
        {
         
            // Leta efter rätt recept i listanforeach (var item in recipeManager.Recipes)
            {
                if (Rec.SelectedItem == null)
                {
                    MessageBox.Show("Du måste välja ett recept för att se detaljerna");
                    return;
                }
                string selectedTitle = Rec.SelectedItem.ToString();
                Recipe selectedRecipe = null;
                foreach (var item in recipeManager.Recipes)
                {
                    
                    if (item.Title == selectedTitle)
                    {
                        selectedRecipe = item;
                        break; // sluta leta när vi hittat rätt        
                    }
                }

                if (selectedRecipe != null)
                {
                    // Skicka med receptet till RecipeDetailWindow        RecipeDetailWindow detailWindow = new RecipeDetailWindow(selectedRecipe);
                    RecipeDetailWindow detailWindow = new RecipeDetailWindow(selectedRecipe);
                    this.Close();
                    detailWindow.Show();
                    
                }
                else
                {
                    MessageBox.Show("Receptet kunde inte hittas.");
                }

            }
        }

        

        private void Remove_Click(object sender, RoutedEventArgs e) // tar bort ett recept från listan
        {
            
            if (Rec.SelectedItem != null)
            {
                removeRecipe();
            }
            else 
            {
                MessageBox.Show("Du måste välja ett recept för att ta bort det");
            }
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)// gör att jag kan logga ut till MainWindow
        {
            
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            
        }

        private void UserDetails_Click(object sender, RoutedEventArgs e)// ser User information
        {
            
             UserDetailsWindow userDetailsWindow = new UserDetailsWindow();
             this.Close();
             userDetailsWindow.Show();
            
        }
        public void ShowRecipe()// visar hur många recept det finns i listan och uppdateras varje gång detta fönstret öppnas 
        {
            for (int i = 0; i < recipeManager.Recipes.Count; i++) 
            {
                if (UserManager.Users[i] == Loggedin)
                {
                   foreach (var item in recipeManager.Recipes) 
                   {

                    if (UserManager.Loggedin == UserManager.Users[1])
                    {
                      Rec.Items.Add(item.Title);
                    }
                    if(UserManager.Loggedin == UserManager.Users[i])
                    {
                       Rec.Items.Add(item.Title);
                    }
                
                   }
                }
            } 

            
        }

        public void removeRecipe()// tar bort recept och söker igenom listan efter en matchande titel och sedan anropa RemoveRecipe
        {
            foreach (var item in recipeManager.Recipes)
            {
                if (Rec.SelectedItem == item.Title) 
                { 
                    recipeManager.RemoveRecipe(item);
                    Rec.Items.Remove(item.Title);
                    break;
                }
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
            this.Close();
        }

        
    }
}
