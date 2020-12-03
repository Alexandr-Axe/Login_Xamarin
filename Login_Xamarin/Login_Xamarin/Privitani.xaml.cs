using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Privitani : ContentPage
    {
        public Privitani(UserLogin UL)
        {
            InitializeComponent();
            labelTitul.Text = UL.Titul;
            labelJmeno.Text = UL.Jmeno;
            labelHeslo.Text = UL.CheckHeslo;
        }
    }
}