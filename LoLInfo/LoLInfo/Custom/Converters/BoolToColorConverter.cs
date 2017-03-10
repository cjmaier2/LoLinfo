using System;
using System.Globalization;
using Xamarin.Forms;

namespace LoLInfo.Custom.Converters
{
    class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            var color = Color.Black;
            if (value is bool)
            {
                color = (bool)value ? Color.Blue : Color.Red;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            if (value is Color)
            {
                return (Color)value == Color.Blue;
            }
            return false;
        }
    }
}
