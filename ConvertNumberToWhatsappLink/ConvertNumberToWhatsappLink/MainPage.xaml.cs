using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ConvertNumberToWhatsappLink
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (GetNumber.Text == null)
            {
                DisplayAlert("خطأ", "الرجاء ادخل رقم الجوال", "الغاء");
            }
            else
            {
                string Url1 = "https://api.whatsapp.com/send?phone=+966" + GetNumber.Text + "";
                Uri uri1 = new Uri(Url1);
                OpenBrowser(uri1);
            }

        }
        public async Task OpenBrowser(Uri uri)
        {
            try
            {
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("خطأ", ex.Message, "الغاء");
                // An unexpected error occured. No browser may be installed on the device.
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (GetNumber.Text == null)
            {
                DisplayAlert("خطأ", "الرجاء ادخل رقم الجوال", "الغاء");
            }
            else
            {
                string Url1 = "https://api.whatsapp.com/send?phone=+966" + GetNumber.Text + "";
              
                ShareUri(Url1);
            }

        }
        public async Task ShareUri(string uri)
        {
            try
            {
                await Share.RequestAsync(uri);
            }
            catch (Exception ex)
            {
                DisplayAlert("خطأ", ex.Message, "الغاء");
                // An unexpected error occured. No browser may be installed on the device.
            }
        }

    }
}
