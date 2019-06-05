using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CIMobile.Pages.Search
{
	public class PdfWebViewPage : ContentPage
	{
		public PdfWebViewPage (string url)
		{
		    var browser = new WebView
		    {
		        Source = url,
		        HorizontalOptions = LayoutOptions.FillAndExpand,
		        VerticalOptions = LayoutOptions.FillAndExpand
		    };

		    Content = browser;
		}
	}
}
