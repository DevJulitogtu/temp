using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CIMobile.ViewModels.Base;
using System.Collections.ObjectModel;
using CIMobile.Services;
using CIMobile.Statics;
using CIMobile.Models;
using Xamarin.Forms;
using CIMobile.Extensions;

namespace CIMobile.ViewModels.People
{
    public class PoliciesViewModel : BaseViewModel
    {
        ObservableCollection<Policy> _policies;
        public ObservableCollection<Policy> Policies
        {
            get { return _policies; }
            set
            {
                _policies = value;
                OnPropertyChanged("Policies");
            }
        }

        readonly IServiceCalls _dataService;

        public PoliciesViewModel()
        {
            this.Title = "Policies";
            //this.Icon = "list.png";

            _dataService = DependencyService.Get<IServiceCalls>();
            Policies = new ObservableCollection<Policy>();

            MessagingCenter.Subscribe<Policy>(this, MessagingServiceConstants.ACCOUNT, (account) =>
            {
                IsInitialized = false;
            });
        }

        Command _loadPoliciesCommand;

        /// <summary>
        /// Command to load policies.
        /// </summary>
        public Command LoadPoliciesCommand
        {
            get { return _loadPoliciesCommand ?? (_loadPoliciesCommand = new Command(async () => await ExecuteLoadPoliciesCommand())); }
        }

        private async Task ExecuteLoadPoliciesCommand()
        {
            IsBusy = true;
            LoadPoliciesCommand.ChangeCanExecute();

            Policies = (await _dataService.GetPolicies()).ToObservableCollection();

            IsBusy = false;
            LoadPoliciesCommand.ChangeCanExecute();
        }

        Command _loadPoliciesRemoteCommand;

        public Command LoadPoliciesRefreshCommand
        {
            get { return _loadPoliciesRemoteCommand ?? (_loadPoliciesRemoteCommand = new Command(async () => await ExecuteLoadAccountsRefreshCommand())); }
        }

        async Task ExecuteLoadAccountsRefreshCommand()
        {
            IsBusy = true;
            LoadPoliciesRefreshCommand.ChangeCanExecute();

            Policies = (await _dataService.GetPolicies()).ToObservableCollection();

            IsBusy = false;
            LoadPoliciesRefreshCommand.ChangeCanExecute();
        }
    }
}
