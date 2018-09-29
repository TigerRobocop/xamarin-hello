using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class MyPage : ContentPage
    {
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
            btn.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new SecondPage());
            };

            Button btnLabel = new Button();
            btnLabel.Text = "Go to label page";
            btnLabel.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new LabelPage());
            };

            Button btnColors = new Button();
            btnColors.Text = "Go to colors page";
            btnColors.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new ColorsListPage());
            };

            Button btnEvents = new Button();
            btnEvents.Text = "Go to Events page";
            btnEvents.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new EventsPage());
            };

            Button btnNumberPad  = new Button();
            btnNumberPad.Text = "Go to NumberPad Page";
            btnNumberPad.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new NumberPadPage());
            };


            var scroll = new ScrollView();

            var stackLayout = new StackLayout
            {

                Children = {
                    new Label { Text = "Hello First", HorizontalTextAlignment = align },
                    btn, btnLabel, btnColors, btnEvents, btnNumberPad
                }
            };

            scroll.Content = stackLayout;

            Content = scroll;

            this.Title = "Main Page";
        }
    }
}

