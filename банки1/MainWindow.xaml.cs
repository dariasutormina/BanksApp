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

namespace банки1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Card> _cards = new List<Card>();
        public MainWindow()
        {
            InitializeComponent();
           
        }
       
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        { 
            double number;
            int month, year, cvc;
            if (int.TryParse(textBoxCVC.Text, out cvc))
            {
                if (int.TryParse(textBoxMonth.Text, out month))
                {
                    if (int.TryParse(textBoxYear.Text, out year))
                    {
                        if (double.TryParse(textBoxNumber.Text, out number))
                        {
                            var card = new Card(textBoxName.Text, number, cvc, year, month);
                            _cards.Add(card);
                            listBoxCards.Items.Add(card.Info);
                            textBoxCVC.Text = "";
                            textBoxMonth.Text = "";
                            textBoxName.Text = "";
                            textBoxNumber.Text = "";
                            textBoxYear.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect insert");
            }

        }
        private void RefreshListBox()
        {
            listBoxCards.ItemsSource = null;
            listBoxCards.ItemsSource = _cards;
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxCards.SelectedIndex != -1)
            {
                _cards.RemoveAt(listBoxCards.SelectedIndex);
                RefreshListBox();
            }
        }

        private void listBoxCards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonDelete.IsEnabled = listBoxCards.SelectedIndex != -1;
        }
    }
}
