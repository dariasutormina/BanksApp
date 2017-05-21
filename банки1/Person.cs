using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataBase
{
    public class Person
    {
                
        public string SurnameName { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int YearOfBirth { get; set; }
        public int MonthOfBirth { get; set; }
        public int DayOfBirth { get; set; }


        public Person(string _surname, string _name,  string _login, string _password, int _yearofbirth, int _monthofbirth, int _dayofbirth )
            {
            SurnameName = _surname;
            Name = _name;
            Login = _login;
            Password = _password;
            YearOfBirth = _yearofbirth;
            MonthOfBirth = _monthofbirth;
            DayOfBirth = _dayofbirth;
            }
        public string SHOW(Person person)
        {
            return string.Format("{0} {1} {2} {3}/{4}/{5}", SurnameName,Name,Login,DayOfBirth,MonthOfBirth,YearOfBirth);
        }
    }
}
