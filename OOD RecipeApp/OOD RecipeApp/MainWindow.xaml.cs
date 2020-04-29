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
        Category[] categoryList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private Category[] GetCategories()
        {
            Dessert Desserts = new Dessert() { Name = "Desserts", DateFormed = 2019};

            Dinner Dinners = new Dinner() { Name = "Dinners", DateFormed = 2017 };

            Category[] categoriesCreated = { Desserts, Dinners};
            return categoriesCreated;
        }

        private void LBCategory_Loaded(object sender, RoutedEventArgs e)
        {
            categoryList = GetCategories();

            Array.Sort(categoryList);

            LBCategory.ItemsSource = categoryList;
        }

        private void BAddCategory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
