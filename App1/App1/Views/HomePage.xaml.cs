using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            var date = DateTime.Now;
            Date.Text = $"{date.ToString("d")}";

            //RectangleImage.WidthRequest = App.ScreenWidth / 4;
            //RectangleImage.HeightRequest = App.ScreenHeight / 3;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CameraPage());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }
    }
}