using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ModernFlyouts.Converters
{
    public class ThumbnailWidthConverter : IValueConverter
    {
        private const double Height = 64.0;
        private const double MaxWidth = 114.0;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not ImageSource image || image.Width <= 0 || image.Height <= 0)
            {
                return Height;
            }

            return Math.Clamp(Height * image.Width / image.Height, Height, MaxWidth);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
