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
    public partial class UserInformation : ContentPage
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void DataLogin_Unfocused(object sender, FocusEventArgs e)
        {
            DataLogin.TextColor = Color.Gray;
            DataLogin.PlaceholderColor = Color.Gray;
            DataRectangle.Stroke = Brush.Gray;

        }

        private void DataLogin_Focused(object sender, FocusEventArgs e)
        {
            DataLogin.TextColor = Color.FromHex("#FA6E09");
            DataLogin.PlaceholderColor = Color.FromHex("#FA6E09");
            DataRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }

        private void Ruler_Focused(object sender, FocusEventArgs e)
        {
            Ruler.TextColor = Color.FromHex("#FA6E09");
            Ruler.PlaceholderColor = Color.FromHex("#FA6E09");
            RulerRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }

        private void Ruler_Unfocused(object sender, FocusEventArgs e)
        {
            Ruler.TextColor = Color.Gray;
            Ruler.PlaceholderColor = Color.Gray;
            RulerRectangle.Stroke = Brush.Gray;
        }

        private void Weight_Focused(object sender, FocusEventArgs e)
        {
            Weight.TextColor = Color.FromHex("#FA6E09");
            Weight.PlaceholderColor = Color.FromHex("#FA6E09");
            WeightRectangle.Stroke = new SolidColorBrush(Color.FromHex("#FA6E09"));
        }

        private void Weight_Unfocused(object sender, FocusEventArgs e)
        {
            Weight.TextColor = Color.Gray;
            Weight.PlaceholderColor = Color.Gray;
            WeightRectangle.Stroke = Brush.Gray;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestionPage());
        }
    }
}