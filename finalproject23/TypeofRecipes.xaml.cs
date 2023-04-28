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
using System.Windows.Shapes;

namespace finalproject23
{
    /// <summary>
    /// Interaction logic for TypeofRecipes.xaml
    /// </summary>
    public partial class TypeofRecipes : Window
    {
        public TypeofRecipes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RecipeOne recipeone = new RecipeOne();
            recipeone.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RecipeTwo recipetwo = new RecipeTwo();
            recipetwo.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RecipeThree recipethree = new RecipeThree();
            recipethree.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RecipeFour recipefour = new RecipeFour();
            recipefour.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            General_Info info = new General_Info();
            info.Show();
            this.Close();
        }
    }
}
