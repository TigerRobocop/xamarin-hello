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

            var stackLayout = new StackLayout {
                Spacing = 10,
                Padding = 20
            };

            //for (int i = 0; i < 100; i++)
            //{
            //    stackLayout.Children.Add(new Label
            //    {
            //        Text = "Value " + i
            //    });
            //}

            foreach (var color in typeof(Color).GetRuntimeFields()) {
                if (color.IsPublic && color.IsStatic && color.FieldType == typeof(Color)) 
                {

                    var colorValue = (Color)color.GetValue(null);


                    RowItem row = new RowItem { Color = color.Name };
                    //Label lblColor = new Label
                    //{
                    //    Text = color.Name,
                    //    TextColor = colorValue,
                    //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    //};

                    //Label lblInfo = new Label
                    //{
                    //    Text = String.Format("{0:X2} - {1:X2} - {2:X2}", 
                    //                         (int)colorValue.R * 255, (int)colorValue.G * 255, (int)colorValue.B * 255),
                    //    FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
                    //};


                    //BoxView boxColor = new BoxView { Color = colorValue };


                    //Frame frame = new Frame
                    //{
                    //    Padding = 10
                    //};

                    //StackLayout cell = new StackLayout { Orientation = StackOrientation.Horizontal };

                    //StackLayout labels = new StackLayout();
                    //labels.Children.Add(lblColor);
                    //labels.Children.Add(lblInfo);

                    //cell.Children.Add(boxColor);
                    //cell.Children.Add(labels);

                    //frame.Content = cell;

                    stackLayout.Children.Add(row);
                }
                   

            }

            scroll.Content = stackLayout;

            Content = scroll;
            this.Title = "Colors List Page";
        }
    }
}

