using App1.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public static int ScreenWidth;
        public static int ScreenHeight;

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                var info = new CameraPage();
                info.DisplayError();
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
