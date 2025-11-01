﻿using SlutUppgift_CookMaster.Manager;
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
       public RecipeManager recipeManager;

        public RecipeListWindow()
        {
            InitializeComponent();
            DataContext = this;
            recipeManager = (RecipeManager)Application.Current.Resources["RecipeManager"];
        }

        
        

        private void AddRecipe_Click(object sender, RoutedEventArgs e)// gives me access to AddRecipeWindow
        {
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            this.Close();
            addRecipeWindow.Show();
        }

        private void Details_Click(object sender, RoutedEventArgs e)//ger mej tillgång till RecipeDetailsWindow
        {
            if (Rec.SelectedItem != null)
            {
            RecipeDetailWindow recipeDetailWindow = new RecipeDetailWindow();
            this.Close();
            recipeDetailWindow.Show();
            }
            else
            {
                MessageBox.Show("Du måste välja ett recept för att se detaljerna");
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
        public void ShowRecipe()// visar hur många recept det finns i listan
        {
            foreach (var item in recipeManager.Recipes) 
            {
                Rec.Items.Add(item.Title);
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
    }
}
