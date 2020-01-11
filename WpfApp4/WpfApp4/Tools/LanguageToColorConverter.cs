using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp4.Tools
{
    public class LanguageToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            {
                if (value is null)
                {
                    {
                        return new SolidColorBrush(Colors.Transparent);
                    }
                }
                return new SolidColorBrush(Colors.LightGoldenrodYellow); ;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
