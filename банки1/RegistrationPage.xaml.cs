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

namespace BankDataBase
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        Person person;

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void buttonAddPerson_Click(object sender, RoutedEventArgs e)
        {
            person = new Person(textBoxSurname.Text, textBoxName.Text, textBoxLogin.Text, passwordBox.Password, Convert.ToInt32(textBoxYearOfBirth.Text), Convert.ToInt32(textBoxMonthOfBirth.Text), Convert.ToInt32(textBoxDayOfBirth.Text));
            textBoxSurname.Text = "";
            textBoxName.Text = "";
            textBoxLogin.Text = "";
            passwordBox.Password = "";
            textBoxYearOfBirth.Text="";
            textBoxMonthOfBirth.Text = "";
            textBoxDayOfBirth.Text = "";
            Pages.MainPage.NewPersonAdded(person);
            NavigationService.Navigate(Pages.MainPage);
        }
    }
}
