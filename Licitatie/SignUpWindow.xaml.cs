using System;
using System.Collections.Generic;
using System.Data;
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
using Dapper;

namespace Licitatie
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var username = usernameTxt.Text;
            var password = PasswordTxt.Password;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid Credentials");
            }
            else
            {
                string sql = "Insert into users (UserName, PassWord, IsAdmin) Values (@username, @password, 0)";
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ConnString")))
                {

                }
            }

        }
    }
}
