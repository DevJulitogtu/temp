using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMobile.Pages;
using CIMobile.Pages.Splash;
using CIMobile.Services;
using Xamarin.Forms;

namespace CIMobile
{
	public partial class App : Application
	{
        static Application app;
        public static Application CurrentApp
        {
            get { return app; }
        }

        readonly IAuthenticationService _AuthenticationService;
        public App()
        {
            InitializeComponent();

            app = this;
            _AuthenticationService = DependencyService.Get<IAuthenticationService>();

            // If the App.IsAuthenticated property is false, modally present the SplashPage.
            if (!_AuthenticationService.IsAuthenticated)
            {
                MainPage = new SplashPage();
            }
            else
            {
                GoToRoot();
            }

        }

        public static void GoToRoot()
        {
            CurrentApp.MainPage = new RootPage();
        }

        public static int AnimationSpeed = 250;
    }
}
