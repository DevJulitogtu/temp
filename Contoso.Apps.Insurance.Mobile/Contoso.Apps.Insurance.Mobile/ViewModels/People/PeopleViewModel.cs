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
    public class PeopleViewModel : BaseViewModel
    {
        ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                OnPropertyChanged("People");
            }
        }

        readonly IServiceCalls _dataService;

        public PeopleViewModel()
        {
            this.Title = "People";
            //this.Icon = "list.png";

            _dataService = DependencyService.Get<IServiceCalls>();
            //_dataService = new WebApiCalls();
            People = new ObservableCollection<Person>();

            MessagingCenter.Subscribe<Person>(this, MessagingServiceConstants.ACCOUNT, (account) =>
            {
                IsInitialized = false;
            });
        }

        Command _loadPeopleCommand;

        /// <summary>
        /// Command to load accounts
        /// </summary>
        public Command LoadPeopleCommand
        {
            get { return _loadPeopleCommand ?? (_loadPeopleCommand = new Command(async () => await ExecuteLoadPeopleCommand())); }
        }

        private async Task ExecuteLoadPeopleCommand()
        {
            IsBusy = true;
            LoadPeopleCommand.ChangeCanExecute();

            People = (await _dataService.GetPeople()).ToObservableCollection();

            IsBusy = false;
            LoadPeopleCommand.ChangeCanExecute();
        }

        Command _loadPeopleRemoteCommand;

        public Command LoadPeopleRefreshCommand
        {
            get { return _loadPeopleRemoteCommand ?? (_loadPeopleRemoteCommand = new Command(async () => await ExecuteLoadAccountsRefreshCommand())); }
        }

        async Task ExecuteLoadAccountsRefreshCommand()
        {
            IsBusy = true;
            LoadPeopleRefreshCommand.ChangeCanExecute();

            People = (await _dataService.GetPeople()).ToObservableCollection();

            IsBusy = false;
            LoadPeopleRefreshCommand.ChangeCanExecute();
        }
    }
}
