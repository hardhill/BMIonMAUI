using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Coverters
{

    public class BmiToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double input = (double)value;
            Color color = Colors.White;
            if (input < 18.5d)
            {
                color = Colors.SkyBlue;
            }
            else if (input < 24.9)
            {
                color = Colors.DarkGreen;
            }
            else if (input < 29.9)
            {
                color = Colors.Gold;
            }
            else
            {
                color = Colors.Red;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
