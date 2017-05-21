using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<Person> _people = new List<Person>();
       /* public MainPage()
        {
            InitializeComponent();
            using (SQLiteConnection connection = new SQLiteConnection("Data source=people.db"))
            {
                connection.Open();
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM people", connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listboxPeople.Items.Add($"id = {reader["id"]}, surname = {reader["surname"]});
                        }
                }
                catch
                {

                }
            }
        }*/
        public void NewPersonAdded(Person person )
        {
            _people.Add(person);
            listBoxPeople.ItemsSource = null;
            listBoxPeople.Items.Add(person.SHOW(person));
        }
    }
}
        

           

