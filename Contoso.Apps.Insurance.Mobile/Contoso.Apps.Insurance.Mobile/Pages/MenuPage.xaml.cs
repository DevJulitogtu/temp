using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMobile.ViewModels.Base;
using Xamarin.Forms;

namespace CIMobile.Pages
{
    public partial class MenuPage : ContentPage
    {
        private readonly RootPage _root;

        public MenuPage(RootPage root)
        {
            List<HomeMenuItem> menuItems;
            this._root = root;
            InitializeComponent();
            BindingContext = new BaseViewModel(Navigation)
            {
                Title = "PolicyConnect",
                Subtitle = "PolicyConnect",
                Icon = "slideout.png",
                AppIcon = new FileImageSource { File = "icon.png" }
            };

            ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = "Policy Holders", MenuType = MenuType.PolicyHolders, Icon = "about.png" },
                    new HomeMenuItem { Title = "Policies", MenuType = MenuType.Policies, Icon = "products.png" },
                    new HomeMenuItem { Title = "People", MenuType = MenuType.People, Icon ="customers.png" },
                    new HomeMenuItem { Title = "Search Policy #", MenuType = MenuType.Search, Icon ="search.png" }
                };

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (ListViewMenu.SelectedItem == null)
                    return;

                await this._root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);
            };
        }
    }
}
