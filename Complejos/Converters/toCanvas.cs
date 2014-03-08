using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Complejos.Converters
{
    class toCanvas : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double x = (double)value;
            string s = (string)parameter.ToString();
            bool result;
            bool b = Boolean.TryParse(s, out result);
            x = x * 50;
            if (result) return x + 150;
            else return 150 - x;

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
