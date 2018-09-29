using System;
using System.Reflection;
using Xamarin.Forms;

namespace HelloWorld
{
    public class ColorsListPage : ContentPage
    {
        public ColorsListPage()
        {
            var scroll = new ScrollView();

            var stackLayout = new StackLayout();

            //for (int i = 0; i < 100; i++)
            //{
            //    stackLayout.Children.Add(new Label
            //    {
            //        Text = "Value " + i
            //    });
            //}

            foreach (var color in typeof(Color).GetRuntimeFields()) {
                if (color.IsPublic && color.IsStatic && color.FieldType == typeof(Color)) stackLayout.Children.Add(new Label
                {
                    Text = color.Name,
                    TextColor = (Color)color.GetValue(null),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                });

            }

            scroll.Content = stackLayout;

            Content = scroll;

        }
    }
}

