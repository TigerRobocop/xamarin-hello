using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class LabelPage : ContentPage
    {
        public LabelPage()
        {
            var formattedString = new FormattedString();
    
            var spanDefault = new Span { Text = "Este curso de " };
            var spanRed = new Span { Text = "Desenvolvimento com Xamarin ", 
                ForegroundColor = Color.Red, 
                FontAttributes = FontAttributes.Bold };
            var spanItalic = new Span { Text = "é muito bacana!", 
                FontAttributes = FontAttributes.Italic, 
                ForegroundColor = Color.Gray, 
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };

            formattedString.Spans.Add(spanDefault);
            formattedString.Spans.Add(spanRed);
            formattedString.Spans.Add(spanItalic);

            Content = new StackLayout
            {
                Children = {
                    new Label { FormattedText = formattedString,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center, 
                        HorizontalTextAlignment = TextAlignment.Center
                    }
                }
            };
        }
    }
}

