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
    /// Interaction logic for My_Recipes.xaml
    /// </summary>
    public partial class My_Recipes : Window
    {
        public My_Recipes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TypeOfRecipes recipe = new TypeOfRecipes();
            recipe.Show();
            this.Close();
        }
    }
}
