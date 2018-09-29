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
            btn.Text = "Next page";
            btn.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new SecondPage());
            };

            Button btnLabel = new Button();
            btnLabel.Text = "Label page";
            btnLabel.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new LabelPage());
            };

            Button btnColors = new Button();
            btnColors.Text = "Colors list page";
            btnColors.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new ColorsListPage());
            };

            Button btnEvents = new Button();
            btnEvents.Text = "Events page";
            btnEvents.Clicked += (object sender, EventArgs e) => {
                Navigation.PushAsync(new EventsPage());
            };

            Button btnNumberPad  = new Button();
            btnNumberPad.Text = "NumberPad Page";
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

