using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class MyPage : ContentPage
    {

        void Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }


        public MyPage()
        {
            TextAlignment align = Device.RuntimePlatform == Device.Android ? TextAlignment.Start : TextAlignment.Center;
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        align = TextAlignment.Start;
            //        break;
            //    default:
            //        align = TextAlignment.Center;
            //        break;
            //}

            //TextAlignment align2 = Device.OnPlatform<TextAlignment>(TextAlignment.Center, TextAlignment.Start, TextAlignment.End);

            Button btn = new Button();
            btn.Text = "Go to next page";
            btn.Clicked += Btn_Clicked;
            Content = new StackLayout
            {

                Children = {
                    new Label { Text = "Hello First", HorizontalTextAlignment = align },
                    btn
                }
            };
        }
    }
}

