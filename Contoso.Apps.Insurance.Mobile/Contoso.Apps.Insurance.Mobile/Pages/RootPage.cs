using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CIMobile.Pages.People;
using CIMobile.Pages.Policies;
using CIMobile.Pages.PolicyHolders;
using CIMobile.Pages.Search;
using CIMobile.Statics;
using CIMobile.ViewModels.Base;
using CIMobile.ViewModels.People;
using CIMobile.ViewModels.PolicyHolders;
using CIMobile.ViewModels.Search;
using Xamarin.Forms;

namespace CIMobile.Pages
{
    public class RootPage : MasterDetailPage
    {
        Dictionary<MenuType, NavigationPage> Pages { get; set; }

        public RootPage()
        {
            Pages = new Dictionary<MenuType, NavigationPage>();
            Master = new MenuPage(this);
            BindingContext = new BaseViewModel(Navigation)
            {
                Title = "PolicyConnect",
                Icon = "slideout.png"
            };
            //setup home page
            NavigateAsync(MenuType.PolicyHolders);
        }

        void SetDetailIfNull(Page page)
        {
            if (Detail == null && page != null)
                Detail = page;
        }

        public async Task NavigateAsync(MenuType id)
        {
            if (!Pages.ContainsKey(id))
            {
                switch (id)
                {
                    case MenuType.People:
                        var page = new CRMNavigationPage(new PeoplePage
                        {
                            BindingContext = new PeopleViewModel() { Navigation = this.Navigation },
                            Title = "People",
                            Icon = new FileImageSource { File = "customers.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
                    case MenuType.Policies:
                        page = new CRMNavigationPage(new PoliciesPage
                        {
                            BindingContext = new PoliciesViewModel() { Navigation = this.Navigation },
                            Title = "Policies",
                            Icon = new FileImageSource { File = "products.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
                    case MenuType.PolicyHolders:
                        page = new CRMNavigationPage(new PolicyHoldersPage
                        {
                            BindingContext = new PolicyHoldersViewModel() { Navigation = this.Navigation },
                            Title = "Policy Holders",
                            Icon = new FileImageSource { File = "about.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
                    case MenuType.Search:
                        page = new CRMNavigationPage(new SearchPage
                        {
                            BindingContext = new SearchViewModel() { Navigation = this.Navigation },
                            Title = "Search Policy #",
                            Icon = new FileImageSource { File = "search.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
                }
            }

            Page newPage = Pages[id];
            if (newPage == null)
                return;

            Detail = newPage;

            if (Device.Idiom != TargetIdiom.Tablet)
                IsPresented = false;
        }
    }

    public class CRMNavigationPage : NavigationPage
    {
        public CRMNavigationPage(Page root)
            : base(root)
        {
            Init();
        }

        public CRMNavigationPage()
        {
            Init();
        }

        void Init()
        {
            BarBackgroundColor = Palette._001;
            BarTextColor = Color.White;
            Icon = null;
        }
    }

    public enum MenuType
    {
        People,
        Policies,
        PolicyHolders,
        Search
    }

    public class HomeMenuItem
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.People;
        }

        public string Icon { get; set; }

        public MenuType MenuType { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public int Id { get; set; }
    }

    /*public class RootPage : TabbedPage
    {
        

        public RootPage()
        {
            
            // the Sales tab page
            this.Children.Add(
                new NavigationPage(new SalesDashboardPage())
                { 
                    Title = TextResources.MainTabs_Sales, 
                    Icon = new FileImageSource() { File = "SalesTab" }
                }
            );

            // the Customers tab page
            this.Children.Add(
                new CustomersPage()
                { 
                    BindingContext = new CustomersViewModel(Navigation), 
                    Title = TextResources.MainTabs_Customers, 
                    Icon = new FileImageSource() { File = "CustomersTab" } 
                }
            );

            // the Products tab page
            this.Children.Add(
                new NavigationPage(new CategoryListPage() { BindingContext = new CategoriesViewModel() } )
                { 
                    Title = TextResources.MainTabs_Products, 
                    Icon = new FileImageSource() { File = "ProductsTab" } 
                }
            );
        }
    }*/
}
