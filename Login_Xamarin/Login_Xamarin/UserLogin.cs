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
                    if (Regex.IsMatch(value, "^[a-zA-Z0-9 ]*$"))
                    {
                        foreach (char Item in value)
                        {
                            if (char.IsUpper(Item)) Heslo = value;
                            else Heslo = "Chybí velký znak"; //else displayalert
                        }
                    }
                    else Heslo = "Obsahuje speciální znak nebo nebylo zadáno číslo"; //else displayalert číslo
                } 
                else Heslo = "Krátké heslo"; //else displayalert moc krátký
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