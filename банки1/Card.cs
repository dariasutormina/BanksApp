using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace банки1
{
    class Card
    {
        private string _holrer_name;

        public string Holrer_name
        {
            get { return _holrer_name; }
            set { _holrer_name = value; }
        }
        private double _number;

        public double Number
        {
            get { return _number; }
            set { _number = value; }
        }
        private int _cvc;

        public int Cvc
        {
            get { return _cvc; }
            set { _cvc = value; }
        }
        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        private int _month;

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public Card(string holder_name, double number, int cvc, int year, int month)
        {
            _holrer_name = holder_name;
            _number = number;
            _cvc = cvc;
            _year = year;
            _month = month;
        }
        public string Info
        {
            get
            {
                return $"{_number}  {_year}/{0}{_month}  {_holrer_name}  {_cvc}";
            }
        }
    }
}
