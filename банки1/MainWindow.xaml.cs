﻿using System;
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
using System.Xml.Serialization;


namespace BankDataBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            frameMain.Navigate(new LoginPage());


            using (SQLiteConnection connection = new SQLiteConnection("Data source=people.db"))
            {
                connection.Open();

                try
                {
                    CreateTables(connection);
                }
                catch
                { }


            }
        }
        static void CreateTables(SQLiteConnection connection)
        {

            SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE people (id integer primary key, surname varchar(100), name varchar(100), login varchar(100), password varchar(100), year int, month int, day int)", connection);
            cmd.ExecuteNonQuery();
        }

      

    }
}
