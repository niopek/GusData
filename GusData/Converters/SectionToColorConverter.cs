using GusData.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace GusData.Converters
{
    public class SectionToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Section section)
            {
                if (section.NameOfLevel == "Temat")
                {
                    return new SolidColorBrush(Colors.Green);
                }
                if (section.NameOfLevel == "Zakres informacyjny")
                {
                    return new SolidColorBrush(Colors.Red);
                }
                if (section.NameOfLevel == "Dziedzina")
                {
                    return new SolidColorBrush(Colors.Yellow);
                }
            }

            return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
