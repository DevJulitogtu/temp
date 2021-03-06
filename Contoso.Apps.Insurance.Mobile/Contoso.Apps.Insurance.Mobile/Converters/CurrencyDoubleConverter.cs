﻿
using System;
using Xamarin.Forms;
using System.Globalization;
using CIMobile.Localization;

namespace CIMobile.Converters
{
    public class CurrencyDoubleConverter : IValueConverter
    {
        readonly ILocalize _Localize;

        public CurrencyDoubleConverter()
        {
            _Localize = DependencyService.Get<ILocalize>();
        }

        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
                return $"{(double) value:C}";
            return value;
                    
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double result;
            if (double.TryParse((value as string), NumberStyles.Currency, _Localize.GetCurrentCultureInfo(), out result))
                return result;
            return value;
        }

        #endregion
    }
}

