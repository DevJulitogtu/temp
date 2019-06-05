using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMobile.Models.Local;
using CIMobile.Pages.Base;
using CIMobile.ViewModels.Search;
using Xamarin.Forms;

namespace CIMobile.Pages.Search
{
	public partial class SearchResultPage : SearchResultPageXaml
    {
		public SearchResultPage ()
		{
			InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        ViewModel.OpenPdfCommand.Execute(null);
	    }
	}

    public abstract class SearchResultPageXaml : ModelBoundContentPage<SearchResultViewModel>
    {
        
    }
}
