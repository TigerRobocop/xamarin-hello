using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class RowItem : ContentView
    {
        public RowItem()
        {
            InitializeComponent();
        }

        public string Color
        {
            get
            {
                return lblColor.Text;
            }

            set
            {
                ColorTypeConverter cv = new ColorTypeConverter();
                Color color = (Color)cv.ConvertFromInvariantString(value);

                lblColor.Text = value;
                lblColor.TextColor = color;

                boxColor.Color = color;

                lblInfo.Text = String.Format("{0:X2} - {1:X2} - {2:X2}",
                                             (int)color.R * 255, (int)color.G * 255, (int)color.B * 255);
            }
        }
    }
}
