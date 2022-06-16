using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraPage : ContentPage
    {
        Image img;
        Button takePhotoBtn;
        Button getPhotoBtn;
        Button calcuatePhotoBtn;

        public CameraPage()
        {
            //InitializeComponent();
            takePhotoBtn = new Button { Text = "Сделать фото" };
            getPhotoBtn = new Button { Text = "Выбрать фото" };
            calcuatePhotoBtn = new Button { Text = "Рассчитать калории" };
            calcuatePhotoBtn.Clicked += ClickedButton;
            img = new Image();

            // выбор фото
            getPhotoBtn.Clicked += GetPhotoAsync;

            // съемка фото
            takePhotoBtn.Clicked += TakePhotoAsync;

            Content = new StackLayout
            {
                Margin = new Thickness(30),
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new StackLayout
                    {
                         Children = {takePhotoBtn, getPhotoBtn},
                         Orientation =StackOrientation.Horizontal,
                         HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    img,
                    calcuatePhotoBtn
                }
            };
        }

        private async void GetPhotoAsync(object sender, EventArgs e)
        {
            try
            {
                // выбираем фото
                var photo = await MediaPicker.PickPhotoAsync();
                // загружаем в ImageView
                img.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        private async void TakePhotoAsync(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
                {
                    Title = $"xamarin.{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.png"
                });

                // для примера сохраняем файл в локальном хранилище
                var newFile = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);
                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);

                // загружаем в ImageView
                img.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        private void ClickedButton(object sender, EventArgs e)
        {
            if (img.Source is null)
                DisplayAlert("Сообщение об ошибке", "Выберите, либо сделайте фото", "OK");
            else
            {
                Thread.Sleep(5000);
                Label label = new Label
                {
                    VerticalTextAlignment = TextAlignment.Start,
                    HorizontalTextAlignment = TextAlignment.Center,
                    Padding = new Thickness(20),
                    Text = "Пищевая ценность на 100 г",
                    FontSize = 16,
                    TextColor = Color.White
                };

                var data = new string[] { "Калорийность:\t219 ккал", "Белки:\t9.9 ккал", "Жиры:\t13.9 ккал", "Углеводы:\t13.5 ккал", "Пищевые волокна: 1 гр" };

                ListView listView = new ListView();
                // определяем источник данных
                listView.ItemsSource = data;

                Content = new StackLayout
                {
                    Margin = new Thickness(30),
                    HorizontalOptions = LayoutOptions.Center,
                    Children = {
                    new StackLayout
                    {
                         Children = {takePhotoBtn, getPhotoBtn},
                         Orientation =StackOrientation.Horizontal,
                         HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    img,
                    calcuatePhotoBtn,
                    label,
                    listView
                    }
                };
            }
        }

        public void DisplayError()
        {
            DisplayAlert("Сообщение об ошибке", "Выберите, либо сделайте фото", "OK");
        }
    }
}