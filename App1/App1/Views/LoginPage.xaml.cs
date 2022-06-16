using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            UserLogin.Text = Password.Text = "";
            Navigation.PushAsync(new RegisterPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!(UserLogin.Text is null && Password.Text is null)
                && UserLogin.Text.Equals("admin") && Password.Text.Equals("123"))
                Navigation.PushAsync(new CameraPage());
            else
                DisplayAlert("Упс...", "Пароль либо логин введен неверно", "Ок");
            Password.Text = UserLogin.Text = "";
        }

        private void Password_Unfocused(object sender, FocusEventArgs e)
        {
            Password.TextColor = Color.Gray;
            Password.PlaceholderColor = Color.Gray;
            PasswordRectangle.Stroke = Brush.Gray;
        }

        private void Password_Focused(object sender, FocusEventArgs e)
        {
            Password.TextColor = Color.FromHex("#FA6E09");
            Password.PlaceholderColor = Color.FromHex("#FA6E09");
            PasswordRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }

        private void UserLogin_Unfocused(object sender, FocusEventArgs e)
        {
            UserLogin.TextColor = Color.Gray;
            UserLogin.PlaceholderColor = Color.Gray;
            UserRectangle.Stroke = Brush.Gray;
        }

        private void UserLogin_Focused(object sender, FocusEventArgs e)
        {
            UserLogin.TextColor = Color.FromHex("#FA6E09");
            UserLogin.PlaceholderColor = Color.FromHex("#FA6E09");
            UserRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }
    }
}