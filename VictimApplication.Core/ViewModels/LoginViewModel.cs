using System;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.ViewModels;
using System.Windows.Input;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Acr.UserDialogs;

namespace VictimApplication.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private readonly IApi _api;
        private readonly IUserDialogs _userDialogs;
        public LoginViewModel(IApi api, IUserDialogs userDialogs)
        {
            _api = api;
            _userDialogs = userDialogs;
        }

        private string _login = "";

        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _password = "";

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public IMvxCommand LoginCommand => new MvxAsyncCommand(LoginToMenu);
        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);
        public IMvxCommand RegisterCommand => new MvxCommand(Register);



        async Task LoginToMenu()
        {
            var user = new UserToLoginDto
            {
                UserName = Login,
                Password = this.Password
            };
            try
            {
                LoggedUserDto loggedUser = await _api.Login(user);
                ShowViewModel<MenuViewModel>();
                if (loggedUser.UserType == "P")
                    _userDialogs.Alert("Logged as Police");
                else if (loggedUser.UserType == "U")
                    _userDialogs.Alert("Logged as User");
                ShowViewModel<MenuViewModel>();
            }
            catch (Exception ex)
            {
                _userDialogs.Alert(ex.Message);
            }

        }

        private void Register()
        {
            ShowViewModel<RegisterViewModel>();

        }

        private void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }

    }
}
