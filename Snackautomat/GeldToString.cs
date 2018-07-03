using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Snackautomat
{
    public class GeldToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
        System.Globalization.CultureInfo culture)
        {
            if (typeof(double) == value.GetType())
            {
                double wert = (double)value;
                return wert.ToString("0.##") + "€";
            }
            else
            {
                return value + "€";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter,
                System.Globalization.CultureInfo culture)
        {
            return value.ToString().Remove(value.ToString().Length);
        }
    }
}
