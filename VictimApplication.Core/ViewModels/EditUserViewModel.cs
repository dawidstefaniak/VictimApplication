using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
	public class EditUserViewModel : MvxViewModel<UserListToReturnDto>
    {
        private readonly IApi _api;
        private readonly IUserDialogs _userDialogs;
		public EditUserViewModel(IApi api, IUserDialogs userDialogs)
        {
            _api = api;
            _userDialogs = userDialogs;
        }
		private UserListToReturnDto currentUser;

		private int _userId;
		public int UserId
        {
			get { return _userId; }
			set { SetProperty(ref _userId, value); }
        }

		private string _userName;
        public string UserName
		{
			get { return _userName; }
			set { SetProperty(ref _userName, value); }
		}

		private string _password;
        public string Password
        {
			get { return _password; }
			set { SetProperty(ref _password, value); }
        }
		private string _firstName;
        public string FirstName
        {
			get { return _firstName; }
			set { SetProperty(ref _firstName, value); }
        }

		private string _secondName;
        public string SecondName
        {
			get { return _secondName; }
			set { SetProperty(ref _secondName, value); }
        }

		private string _email;
        public string Email
        {
			get { return _email; }
			set { SetProperty(ref _email, value); }
        }

		private string _userType;
        public string UserType
        {
			get { return _userType; }
			set { SetProperty(ref _userType, value); }
        }
        
		public IMvxCommand EditUserCommand => new MvxAsyncCommand(EditUser);

        public async Task EditUser()
        {
			if (UserType == "U" || UserType == "P" || UserType == "A")
			{
				var UserToEdit = new UserListToReturnDto
				{
					userId = UserId,
					UserName = UserName,
					Password = Password,
					FirstName = FirstName,
					SecondName = SecondName,
					Email = Email,
					UserType = UserType
				};
				await _api.UpdateUser(UserToEdit);
				Close(this);
				_userDialogs.Alert("User updated!");
			}
			else _userDialogs.Alert("User Type incorrect.");
        }

        public override async Task Initialize()
        {
            await base.Initialize();
			currentUser = await _api.GetUserToEdit(currentUser.userId);
            UpdateFormWithUser();
        }

		public void Init(UserListToReturnDto parameter)
        {
            currentUser = parameter;
        }

		public void UpdateFormWithUser()
        {
			UserId = currentUser.userId;
			UserName = currentUser.UserName;
			Password = currentUser.Password;
			FirstName = currentUser.FirstName;
			SecondName = currentUser.SecondName;
			Email = currentUser.Email;
			UserType = currentUser.UserType;
        }

		public override void Prepare(UserListToReturnDto parameter)
		{
			
		}
	}
}
