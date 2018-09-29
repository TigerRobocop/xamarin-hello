using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Title = "Second Page";

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Second" }
                }
            };
        }
    }
}

