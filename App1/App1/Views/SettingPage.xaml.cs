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
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CameraPage());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
        private void ImageButton_Target(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TargetPage());
        }
        private void ImageButton_Tips(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TipsPage());
        }
        private void ImageButton_AboutApplication(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutAppPage());
        }
    }
}