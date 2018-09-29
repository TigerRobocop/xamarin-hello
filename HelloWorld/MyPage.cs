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

        void BtnLabel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LabelPage());
        }

        void BtnColors_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ColorsListPage());
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
            // Modo defasado
            //TextAlignment align2 = Device.OnPlatform<TextAlignment>(TextAlignment.Center, TextAlignment.Start, TextAlignment.End);

            Button btn = new Button();
            btn.Text = "Go to next page";
            btn.Clicked += Btn_Clicked;

            Button btnLabel = new Button();
            btnLabel.Text = "Go to label page";
            btnLabel.Clicked += BtnLabel_Clicked;;

            Button btnColors = new Button();
            btnColors.Text = "Go to colors page";
            btnColors.Clicked += BtnColors_Clicked;;


            var scroll = new ScrollView();

            var stackLayout = new StackLayout
            {

                Children = {
                    new Label { Text = "Hello First", HorizontalTextAlignment = align },
                    btn, btnLabel, btnColors
                }
            };

            scroll.Content = stackLayout;

            Content = scroll;

            this.Title = "Main Page";
        }
    }
}

