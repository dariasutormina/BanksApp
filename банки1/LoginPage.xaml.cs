using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace BankDataBase
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            textBoxLogin.Focus();
        }

        private string CalculateHash(string password)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Convert.ToBase64String(hash);
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            var hash = CalculateHash("123");

            if (textBoxLogin.Text == "dasha" && CalculateHash(passwordBox.Password) == hash)
                NavigationService.Navigate(Pages.MainPage);
            else
                MessageBox.Show("Incorrect login or password");
        }

        private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Using keyboard handling on the page level
            if (e.Key == Key.Enter)
                buttonLogin_Click(null, null);
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.RegistrationPage);
        }
    }
}
