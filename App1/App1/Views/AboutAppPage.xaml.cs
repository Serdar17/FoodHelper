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
    public partial class AboutAppPage : ContentPage
    {
        public string Text { get; set; }
        public AboutAppPage()
        {
            InitializeComponent();
            Label1.Text = " Мы предлагаем простое\n в использовании\n" +
                " приложение, которое по\n" +
                " фотографии распознает\n" +
                " еду, определяет ее\n" +
                " калорийность и при\n" +
                " желании пользователя\n" +
                " выдает рекомендации по\n" +
                " изменению рациона в\n" +
                " соответствии с правилами\n" +
                " здорового питания\n" +
                " и суточной нормы\n потребления";
        }
    }
}