using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\m.ivanova23\Source\Repos\finalproject23\finalproject23\Database1.mdf;Integrated Security=True");

            try
            {


                //opening the connection to the db 

                sqlCon.Open();

                //Build our actual query 

                string query = "INSERT INTO Table([First_name], [Last name], Email, Username, Password)values ('"+txtFirst_name.Text+ "', '" + txtSecond_name.Text + "', '" + txtEmail.Text + "', '" + txtUsername.Text + "', '" + PasswordBox.Password + "')";
                //Establish a sql command

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                LogIn lg = new LogIn();
                lg.Show();
                this.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlCon.Close();

            }
        }
    }
}
