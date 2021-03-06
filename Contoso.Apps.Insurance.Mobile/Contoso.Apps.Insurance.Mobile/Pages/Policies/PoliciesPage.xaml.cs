﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMobile.Pages.Base;
using CIMobile.Statics;
using CIMobile.ViewModels.People;
using CIMobile.Models;
using Xamarin.Forms;

namespace CIMobile.Pages.Policies
{
	public partial class PoliciesPage : PoliciesPageXaml
    {
		public PoliciesPage()
		{
			InitializeComponent ();

            #region wire up MessagingCenter
            // Catch the login success message from the MessagingCenter.
            // This is really only here for Android, which doesn't fire the OnAppearing() method in the same way that iOS does (every time the page appears on screen).
            Device.OnPlatform(Android: () => MessagingCenter.Subscribe<PoliciesPage>(this, MessagingServiceConstants.AUTHENTICATED, sender => OnAppearing()));
            #endregion
        }

        async void PoliciesItemTapped(object sender, ItemTappedEventArgs e)
        {
            var person = (Policy)e.Item;
            //await PushTabbedPage(person);
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel.IsInitialized)
            {
                return;
            }
            ViewModel.LoadPoliciesCommand.Execute(null);
            ViewModel.IsInitialized = true;
        }
    }

    public abstract class PoliciesPageXaml : ModelBoundContentPage<PoliciesViewModel> { }
}
