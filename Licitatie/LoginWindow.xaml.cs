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

namespace Licitatie
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    
    public class Testare
    {
        public bool IsGuest { get; set; }
    }

    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var username = usernameTxt.Text;
            var password = PasswordTxt.Password;

            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid Credentials");
            }
            else
            {
                if(User.UserTest(username, password) >=1)
                {
                    MessageBox.Show("Succesfull login");
                    this.Hide();
                    MainWindow MWindow = new MainWindow();
                    MWindow.Show();
                }
            }
        }
        private void guestLogIn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MWindow = new MainWindow();
            MWindow.Show();
            MWindow.StartBidButton.IsEnabled = false;
            MWindow.BidButton.IsEnabled = false;
            MWindow.AddButton.IsEnabled = false;
            MWindow.DeleteButton.IsEnabled = false;
        }
    }
}
