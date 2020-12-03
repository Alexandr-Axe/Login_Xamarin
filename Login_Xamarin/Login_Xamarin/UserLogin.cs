using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Login_Xamarin
{
    public class UserLogin
    {
        
        public string Titul { get; set; }
        public string Jmeno { get; set; }
        private string Heslo;

        public string CheckHeslo
        {
            get { return Heslo; }
            set 
            {
                if (value.Length >= 8)
                {
                    if (Regex.IsMatch(value, @"\d"))
                    {
                        foreach (char Item in value)
                        {
                            if (char.IsUpper(Item)) Heslo = value;
                            else Heslo = "chybí velký znak"; //else displayalert
                        }
                    }
                    else Heslo = "chybí číslo"; //else displayalert číslo
                } 
                else Heslo = "krátké heslo"; //else displayalert moc krátký
            }
        }

        public UserLogin(string titul, string jmeno, string heslo) 
        {
            Titul = titul;
            Jmeno = jmeno;
            CheckHeslo = heslo;
        }
    }
}
