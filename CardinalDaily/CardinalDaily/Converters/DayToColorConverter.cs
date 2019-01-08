using System;
using System.Globalization;
using CardinalDaily.Models;
using Xamarin.Forms;

namespace CardinalDaily.Converters
{
    public class DayToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Day d)
            {
                if(d.HasBeenSet)
                {
                    return d.Value ? Application.Current.Resources["PositiveBackgroundColor"]
                                   : Application.Current.Resources["NegativeBackgroundColor"];
                }
                return Application.Current.Resources["CardinalTransparentColor"];
            }
            else
            {
                throw new InvalidOperationException("The target must be a Day Object");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
