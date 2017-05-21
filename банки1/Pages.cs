using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataBase
{
   static class Pages
    {
        private static MainPage _mainpage = new MainPage();
        private static LoginPage _loginpage = new LoginPage();
        private static RegistrationPage _registrationpage = new RegistrationPage();

        public static MainPage MainPage
        {
            get
            {
                return _mainpage;
            }
        }

        public static LoginPage LoginPage
        {
            get
            {
                return _loginpage;
            }
        }

        public static RegistrationPage RegistrationPage
        {
            get
            {
                return _registrationpage;
            }
        }
    }
}
