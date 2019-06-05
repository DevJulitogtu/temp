using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms.Platform.Android;

namespace CIMobile.Droid
{
	[Activity (Label = "PolicyConnect", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

            FormsAppCompatActivity.ToolbarResource = Resource.Layout.abc_screen_toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.design_layout_tab_text;
            ImageCircleRenderer.Init();

            LoadApplication (new CIMobile.App ());
		}

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            AuthenticationAgentContinuationHelper.SetAuthenticationAgentContinuationEventArgs(requestCode, resultCode, data);
        }
    }
}

