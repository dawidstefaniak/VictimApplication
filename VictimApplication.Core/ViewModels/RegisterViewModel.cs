using System;
using System.Threading.Tasks;
using System.Linq;
using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class RegisterViewModel : MvxViewModel
    {
        private readonly IApi _api;
        private readonly IMvxJsonConverter _jsonConverter;
        private readonly IUserDialogs _userDialogs;
        public RegisterViewModel(IApi api, IMvxJsonConverter jsonConverter, IUserDialogs userDialogs)
        {
            _api = api;
            _jsonConverter = jsonConverter;
            _userDialogs = userDialogs;
        }


        private string _login = "";

        public string Login
        {
            get => _login;
            set { SetProperty(ref _login, value); }
        }
        private string _password = "";

        public string Password
        {
            get => _password;
            set { SetProperty(ref _password, value); }
        }
        private string _firstname = "";

        public string Firstname
        {
            get => _firstname;
            set { SetProperty(ref _firstname, value); }
        }
        private string _surname = "";

        public string Surname
        {
            get => _surname;
            set { SetProperty(ref _surname, value); }
        }
        private string _email = "";

        public string Email
        {
            get => _email;
            set { SetProperty(ref _email, value); }
        }


        public IMvxCommand RegisterCommand => new MvxAsyncCommand(Register);
        public IMvxCommand BackCommand => new MvxCommand(BackToLogin);

        private void BackToLogin()
        {
            ShowViewModel<MenuViewModel>();
        }

        async Task Register()
        {
			if (CheckFields())
			{
				var UserForCreation = new UserForCreationDto
				{
					UserName = Login,
					Password = this.Password,
					FirstName = this.Firstname,
					SecondName = this.Surname,
					Email = this.Email
				};
				try
				{
					await _api.CreateUser(UserForCreation);
					Close(this);
                    _userDialogs.Alert("Succesfully Registered! Now you can login to your account.");
				}
				catch (Exception ex)
				{
					Close(this);
					_userDialogs.Alert("Registration unsuccesfull.", "Error", "OK");
				}            
			}
        }

		private bool CheckFields()
		{
			if(Login.Length<4 || Login.Length>17)
			{
				_userDialogs.Alert("Login has to be between 4 and 16 characters.");
				return false;
			}
			if (Password.Length < 4 || Password.Length > 17)
            {
                _userDialogs.Alert("Password has to be between 4 and 16 characters.");
                return false;
            }
			if(Firstname.Length<2 || Surname.Length<2 || Firstname.Length>50 || Surname.Length>50)
			{
				_userDialogs.Alert("Please check your name.");
				return false;
			}
			if(!Email.Contains('@') || Email.Contains(' '))
			{
				_userDialogs.Alert("Please write correct E-mail");
				return false;
			}
			return true;
		}

    }
}