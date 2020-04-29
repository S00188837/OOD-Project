using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_RecipeApp 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Category SelectedCategory;
        Recipe SelectedRecipe;

        List<Category> categoryList = new List<Category>();
        List<Recipe> recipeList = new List<Recipe>();



        public MainWindow()
        {
            InitializeComponent();
        }

        private void BAddCategory_Click(object sender, RoutedEventArgs e)
        {
            categoryList.Add(new Category(TBCategory.Text, DateTime.Now.Year));

            LBCategory.ItemsSource = null;
            LBCategory.ItemsSource = categoryList;

            TBCategory.Text = null;
        }

        private void BRemoveCategory_Click(object sender, RoutedEventArgs e)
        {
            categoryList.Remove(LBCategory.SelectedItem as Category);
            LBCategory.ItemsSource = null;
            LBCategory.ItemsSource = categoryList;

            LBRecipe.ItemsSource = null;
        }

        private void BAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedCategory != null)
            {
                SelectedCategory.Recipes.Add(new Recipe(TBRecipe.Text, DateTime.Now));

                LBRecipe.ItemsSource = null;
                LBRecipe.ItemsSource = SelectedCategory.Recipes;

                TBRecipe.Text = null;
            }
        }

        private void BRemoveRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedRecipe != null)
            {
                SelectedCategory.Recipes.Remove(SelectedRecipe);

                LBRecipe.ItemsSource = null;
                LBRecipe.ItemsSource = SelectedCategory.Recipes;
            }
        }

        private void LBCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCategory = LBCategory.SelectedItem as Category;

            if (LBCategory.SelectedItem != null)
            {
                LBRecipe.ItemsSource = null;
                LBRecipe.ItemsSource = SelectedCategory.Recipes;
            }
        }

        private void LBRecipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedRecipe = LBRecipe.SelectedItem as Recipe;

            if (SelectedRecipe != null)
            {
                
            }
        }

    }
}
