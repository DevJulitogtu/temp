using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CIMobile.ViewModels.Base;
using System.Collections.ObjectModel;
using CIMobile.Services;
using CIMobile.Statics;
using CIMobile.Models;
using CIMobile.Models.Local;
using Xamarin.Forms;
using CIMobile.Extensions;

namespace CIMobile.ViewModels.Search
{
    public class SearchViewModel : BaseViewModel
    {
        ObservableCollection<Value> _results;
        public ObservableCollection<Value> Results
        {
            get { return _results; }
            set
            {
                _results = value;
                OnPropertyChanged("Results");
            }
        }

        private string _policyNumber;
        public string PolicyNumber
        {
            get { return _policyNumber; }
            set
            {
                _policyNumber = value;
                OnPropertyChanged("PolicyNumber");
            }
        }

        readonly IServiceCalls _dataService;

        public SearchViewModel()
        {
            this.Title = "Search Results";
            //this.Icon = "list.png";

            _dataService = DependencyService.Get<IServiceCalls>();
            Results = new ObservableCollection<Value>();

            MessagingCenter.Subscribe<Value>(this, MessagingServiceConstants.ACCOUNT, (account) =>
            {
                IsInitialized = false;
            });
        }

        Command _searchCommand;

        /// <summary>
        /// Command to search by Policy Number.
        /// </summary>
        public Command SearchCommand
        {
            get { return _searchCommand ?? (_searchCommand = new Command(async () => await ExecuteSearchCommand())); }
        }

        private async Task ExecuteSearchCommand()
        {
            IsBusy = true;
            SearchCommand.ChangeCanExecute();

            Results = (await _dataService.SearchForPdf(PolicyNumber)).ToObservableCollection();

            IsBusy = false;
            SearchCommand.ChangeCanExecute();
        }

        Command _searchRemoteCommand;

        public Command SearchRefreshCommand
        {
            get { return _searchRemoteCommand ?? (_searchRemoteCommand = new Command(async () => await ExecuteSearchRefreshCommand())); }
        }

        async Task ExecuteSearchRefreshCommand()
        {
            IsBusy = true;
            SearchRefreshCommand.ChangeCanExecute();

            Results = (await _dataService.SearchForPdf(PolicyNumber)).ToObservableCollection();

            IsBusy = false;
            SearchRefreshCommand.ChangeCanExecute();
        }
    }
}
