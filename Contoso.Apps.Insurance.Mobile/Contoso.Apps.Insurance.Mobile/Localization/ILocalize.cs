using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CIMobile.Localization
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
