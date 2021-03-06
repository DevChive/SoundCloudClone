﻿using System;
using System.Globalization;
using Humanizer;
using Xamarin.Forms;

namespace SoundCloudClone.Converters
{
    public class NumericalToMetricConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int numeric)
                return numeric.ToMetric(decimals: 0);

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
