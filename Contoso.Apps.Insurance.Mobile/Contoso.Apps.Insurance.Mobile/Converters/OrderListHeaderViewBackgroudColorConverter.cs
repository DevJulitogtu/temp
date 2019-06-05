
using System;
using Xamarin.Forms;
using CIMobile.Statics;

namespace CIMobile.Converters
{
    public class OrderListHeaderViewBackgroudColorConverter : IValueConverter
	{
        #region IValueConverter implementation
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((string)value == "Order Open")
                return Palette._003;

            if ((string)value == "Order Closed")
                return Palette._017;

            return Palette._008;
            
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
	}
}

