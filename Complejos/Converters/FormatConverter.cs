using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Complejos.Converters
{
    class FormatConverter:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double n = (double)value;
            return n.ToString("F2");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            try
            {
                string n = (string)value;
                return Double.Parse(n);
            }
            catch (Exception)
            {
                return (string)value;
            }
        }
    }
}
