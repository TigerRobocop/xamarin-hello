using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class EventsPage : ContentPage
    {

        StackLayout log;
        Button btnAdd, btnRemove;

        public EventsPage()
        {
            btnAdd = new Button
            {
                Text = "Add log", ClassId = "btnAdd", 
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            btnRemove = new Button
            {
                Text = "Remove log", ClassId = "btnRemove",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout buttons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };

            btnAdd.Clicked += Btn_Clicked;
            btnRemove.Clicked += Btn_Clicked;

            buttons.Children.Add(btnAdd);
            buttons.Children.Add(btnRemove);


            log = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            Content = new StackLayout
            {
                Children = {
                    buttons, log
                }
            };

            this.Title = "Button Events";
            btnRemove.IsEnabled = log.Children.Count > 0;
        }

        void Btn_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.ClassId == "btnAdd") {

                btnRemove.IsEnabled = true;

                Label currentDate = new Label
                {
                    Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString()
                };

                log.Children.Add(currentDate);

            } else {

                log.Children.RemoveAt(0);

                btnRemove.IsEnabled = log.Children.Count > 0;

            }
        }
    }
}

