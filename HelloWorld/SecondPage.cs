using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Second" }
                }
            };
        }
    }
}

