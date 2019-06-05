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

namespace CIMobile.ViewModels.PolicyHolders
{
    public class PolicyHoldersViewModel : BaseViewModel
    {
        ObservableCollection<PolicyHolderViewModel> _policyHolders;
        public ObservableCollection<PolicyHolderViewModel> PolicyHolders
        {
            get { return _policyHolders; }
            set
            {
                _policyHolders = value;
                OnPropertyChanged("PolicyHolders");
            }
        }

        readonly IServiceCalls _dataService;

        public PolicyHoldersViewModel()
        {
            this.Title = "Policy Holders";
            //this.Icon = "list.png";

            _dataService = DependencyService.Get<IServiceCalls>();
            PolicyHolders = new ObservableCollection<PolicyHolderViewModel>();

            MessagingCenter.Subscribe<PolicyHolderViewModel>(this, MessagingServiceConstants.ACCOUNT, (account) =>
            {
                IsInitialized = false;
            });
        }

        Command _loadPolicyHoldersCommand;

        /// <summary>
        /// Command to load policies.
        /// </summary>
        public Command LoadPolicyHoldersCommand
        {
            get { return _loadPolicyHoldersCommand ?? (_loadPolicyHoldersCommand = new Command(async () => await ExecuteLoadPolicyHoldersCommand())); }
        }

        private async Task ExecuteLoadPolicyHoldersCommand()
        {
            IsBusy = true;
            LoadPolicyHoldersCommand.ChangeCanExecute();

            PolicyHolders = (await _dataService.GetPolicyHolders()).ToObservableCollection();

            //var searchResult = await _dataService.SearchForPdf("DOW586IJCG493F");

            IsBusy = false;
            LoadPolicyHoldersCommand.ChangeCanExecute();
        }

        Command _loadPolicyHoldersRemoteCommand;

        public Command LoadPolicyHoldersRefreshCommand
        {
            get { return _loadPolicyHoldersRemoteCommand ?? (_loadPolicyHoldersRemoteCommand = new Command(async () => await ExecuteLoadAccountsRefreshCommand())); }
        }

        async Task ExecuteLoadAccountsRefreshCommand()
        {
            IsBusy = true;
            LoadPolicyHoldersRefreshCommand.ChangeCanExecute();

            PolicyHolders = (await _dataService.GetPolicyHolders()).ToObservableCollection();

            IsBusy = false;
            LoadPolicyHoldersRefreshCommand.ChangeCanExecute();
        }
    }
}
