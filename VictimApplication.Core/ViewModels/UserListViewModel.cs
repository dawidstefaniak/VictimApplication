using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class UserListViewModel : MvxViewModel
    {
        private LoggedUserDto user = new LoggedUserDto();
        private readonly IApi _api;

		private IEnumerable<UserListToReturnDto> listOfUsers;
		private MvxObservableCollection<UserListToReturnDto> usersobservable = new MvxObservableCollection<UserListToReturnDto>();

		public UserListViewModel(IApi api)
        {
            _api = api;
        }
        private string _information;
        public string Information
        {
            get { return _information; }
            set { SetProperty(ref _information, value); }
        }

		public MvxObservableCollection<UserListToReturnDto> UsersObservable
        {
            get { return usersobservable; }
            set { SetProperty(ref usersobservable, value); }
        }

		public IEnumerable<UserListToReturnDto> ListOfUsers
        {
            get { return listOfUsers; }
			set { SetProperty(ref listOfUsers, value); }
        }

        public override async Task Initialize()
        {
            Information = user.UserId.ToString();
            await GetUsers();
            await base.Initialize();
            // do something with _initialParameter
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);
        public IMvxCommand LoadUsersCommand => new MvxAsyncCommand(GetUsers);
		public IMvxCommand EditUserCommand => new MvxCommand<UserListToReturnDto>((currentUser) => ShowViewModel<EditUserViewModel>(currentUser));


		public async Task GetUsers()
        {
            //Data is userId parameter which will be send by API in get method
            try
            {
				ListOfUsers = await _api.GetListOfUsers();

				foreach (var users in ListOfUsers)
                {
					UsersObservable.Add(users);
                }
            }
            catch (Exception ex)
            {
                _information = ex.Message;
            }
        }

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
