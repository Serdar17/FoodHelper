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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void UserLogin_Focused(object sender, FocusEventArgs e)
        {
            UserLogin.TextColor = Color.FromHex("#FA6E09");
            UserLogin.PlaceholderColor = Color.FromHex("#FA6E09");
            UserRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
            //UserImage.Source = ImageSource.FromResource("image.png");
            //UserImage = new Image()
            //{
            //    Source = ImageSource.FromResource("image1.png"),
            //    WidthRequest = 25,
            //    HeightRequest = 25
            //};

        }

        private void UserLogin_Unfocused(object sender, FocusEventArgs e)
        {
            UserLogin.TextColor = Color.Gray;
            UserLogin.PlaceholderColor = Color.Gray;
            UserRectangle.Stroke = Brush.Gray;
            //UserImage.Source = ImageSource.FromResource("user1.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var entryCount = RegisterLayout.Children
                .Where(item => item.GetType().Equals(typeof(Entry)))
                .Select(item => (Entry)item)
                .Where(item => !(item.Text is null) && item.Text.Length > 0)
                .Count();


            Navigation.PushAsync(new UserInformation());
            //if (entryCount == 4)
            //    Navigation.PushAsync(new HomePage());
            //else
            //    DisplayAlert("Ошибка регистрации", "Заполните все поля для регистрации", "Ок");
            //foreach (var item1 in entry)
            //{

            //}
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void Password_Focused(object sender, FocusEventArgs e)
        {
            Password.TextColor = Color.FromHex("#FA6E09");
            Password.PlaceholderColor = Color.FromHex("#FA6E09");
            PasswordRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }

        private void Password_Unfocused(object sender, FocusEventArgs e)
        {
            Password.TextColor = Color.Gray;
            Password.PlaceholderColor = Color.Gray;
            PasswordRectangle.Stroke = Brush.Gray;
        }

        private void Email_Focused(object sender, FocusEventArgs e)
        {
            Email.TextColor = Color.FromHex("#FA6E09");
            Email.PlaceholderColor = Color.FromHex("#FA6E09");
            EmailRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }

        private void Email_Unfocused(object sender, FocusEventArgs e)
        {
            Email.TextColor = Color.Gray;
            Email.PlaceholderColor = Color.Gray;
            EmailRectangle.Stroke = Brush.Gray;
        }

        private void ConfirmPassword_Focused(object sender, FocusEventArgs e)
        {
            ConfirmPassword.TextColor = Color.FromHex("#FA6E09");
            ConfirmPassword.PlaceholderColor = Color.FromHex("#FA6E09");
            ConfirmPasswordRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }

        private void ConfirmPassword_Unfocused(object sender, FocusEventArgs e)
        {
            ConfirmPassword.TextColor = Color.Gray;
            ConfirmPassword.PlaceholderColor = Color.Gray;
            ConfirmPasswordRectangle.Stroke = Brush.Gray;
        }
    }
}