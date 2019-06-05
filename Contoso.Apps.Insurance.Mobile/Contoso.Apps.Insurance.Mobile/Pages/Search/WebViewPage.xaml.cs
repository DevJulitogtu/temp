using Xamarin.Forms;

namespace CIMobile.Pages.Search
{
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage (string url)
		{
		    Content = new CustomWebView
		    {
		        Uri = url,
		        HorizontalOptions = LayoutOptions.FillAndExpand,
		        VerticalOptions = LayoutOptions.FillAndExpand
		    };
		}
	}
}
