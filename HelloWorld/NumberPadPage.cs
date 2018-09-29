using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class NumberPadPage : ContentPage
    {
        Label output;


        public NumberPadPage()
        {

            output = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            StackLayout keyboard = new StackLayout();

            Button backspace = new Button
            {
                Text = "\u21E6", StyleId = "btnClear"
            };

            backspace.Clicked += Key_Clicked; 
            keyboard.Children.Add(backspace);

            StackLayout row = new StackLayout { Orientation = StackOrientation.Horizontal };
            keyboard.Children.Add(row);

            for (int i = 1; i < 10; i++)
            {
                Button key = new Button
                {
                    Text = i.ToString(), StyleId = i.ToString()
                };
                key.Clicked += Key_Clicked;
                row.Children.Add(key);

                if (i % 3 == 0) {
                    row = new StackLayout { Orientation = StackOrientation.Horizontal };
                    keyboard.Children.Add(row);
                }
            }

            Button zero = new Button
            {
                Text = "0", StyleId = "0"
            };

            keyboard.Children.Add(zero);


            Content = new StackLayout
            {
                Children = {
                    output, keyboard
                }
            };

            var settings = Application.Current.Properties;
            if (settings.ContainsKey(App.keypadOutput)) {
                output.Text = settings[App.keypadOutput].ToString();
            }
        }



        void Key_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.StyleId == "btnClear" && output.Text.Length > 0) {
                output.Text = output.Text.Substring(0, output.Text.Length - 1);
            } else {
                output.Text += btn.StyleId;
                Application.Current.Properties[App.keypadOutput] = output.Text;
            }
        }

    }
}

