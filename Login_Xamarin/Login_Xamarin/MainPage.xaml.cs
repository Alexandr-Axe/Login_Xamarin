using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        UserLogin UL;
        private void varta_Clicked(object sender, EventArgs e)
        {
            UL = new UserLogin(Titulko.SelectedItem.ToString(), Username.Text, UPassword.Text);
            if (UL.CheckHeslo != UPassword.Text) Application.Current.MainPage.DisplayAlert("Chyba", UL.CheckHeslo, "OK");
            else
            {
                Page p = new Privitani(UL);
                Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(p));
            }
        }
    }
}