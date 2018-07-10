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
            double wert;
            if (typeof(string) == value.GetType())
            {                
                if ((string)value != "")
                {
                    wert = System.Convert.ToDouble(value);
                    return String.Format("{0:0.00}", wert) + "€";
                }
            }
            if (typeof(double) == value.GetType())
            {
                wert = (double)value;
                return String.Format("{0:0.00}", wert) + "€";
            }
            else
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter,
                System.Globalization.CultureInfo culture)
        {
            return value.ToString().Remove(value.ToString().Length);
        }
    }
}
