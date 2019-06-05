
using Xamarin.Forms;

namespace CIMobile
{
    public static class StringExtensions
    {
        public static string CapitalizeForAndroid(this string str)
        {
            return Device.OS == TargetPlatform.Android ? str.ToUpper() : str;
        }
    }
}

