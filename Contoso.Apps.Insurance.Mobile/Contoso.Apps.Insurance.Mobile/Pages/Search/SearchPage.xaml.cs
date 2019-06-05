using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMobile.Pages.Base;
using CIMobile.Statics;
using CIMobile.ViewModels.People;
using CIMobile.Models.Local;
using CIMobile.Pages.Policies;
using CIMobile.ViewModels.Search;
using Xamarin.Forms;

namespace CIMobile.Pages.Search
{
	public partial class SearchPage : SearchPageXaml
    {
		public SearchPage()
		{
			InitializeComponent ();

		    BindingContext = new SearchViewModel();

            #region wire up MessagingCenter
            // Catch the login success message from the MessagingCenter.
            // This is really only here for Android, which doesn't fire the OnAppearing() method in the same way that iOS does (every time the page appears on screen).
            Device.OnPlatform(Android: () => MessagingCenter.Subscribe<PoliciesPage>(this, MessagingServiceConstants.AUTHENTICATED, sender => OnAppearing()));
            #endregion
        }

        async void ResultItemTapped(object sender, ItemTappedEventArgs e)
        {
            var result = (Value)e.Item;
            await Navigation.PushAsync(new SearchResultPage()
            {
                BindingContext = new SearchResultViewModel(result)
                {
                    Navigation = Navigation
                }
            });
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel.IsInitialized)
            {
                return;
            }
            //ViewModel.SearchCommand.Execute(null);
            //ViewModel.PolicyNumber = "BRO";
            ViewModel.IsInitialized = true;
        }

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        if (!string.IsNullOrWhiteSpace(ViewModel.PolicyNumber))
	        {
	            ViewModel.SearchCommand.Execute(null);
	        }
	        else
	        {
	            //TODO: Display error message
	        }
	    }
    }

    public abstract class SearchPageXaml : ModelBoundContentPage<SearchViewModel> { }
}
