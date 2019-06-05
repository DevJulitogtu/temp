using Xamarin.Forms;

namespace CIMobile.Pages.Search
{
	public class WebViewPageCS : ContentPage
	{
		public WebViewPageCS (string url)
		{
			Padding = new Thickness (0, 20, 0, 0);
			Content = new StackLayout { 
				Children = {
					new CustomWebView {
						Uri = url,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						VerticalOptions = LayoutOptions.FillAndExpand
					}
				}
			};
		}
	}
}
