using System;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.ViewModels;
using System.Windows.Input;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace VictimApplication.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private readonly IApi _api;
        public LoginViewModel(IApi api)
        {
            _api = api;
        }

        public void Init(User user = null)
        {
            _user = user == null ? new User() : user;
            RaiseAllPropertiesChanged();
        }

        User _user;

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

        public IMvxCommand LoginCommand => new MvxCommand(LoginToMenu);
        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);
        public IMvxCommand ShowMenuCommand2 => new MvxAsyncCommand(CallApi);
        public IMvxCommand RegisterCommand => new MvxCommand(Register);



        private void LoginToMenu()
        {
            if (_user.IsValid())
            {
                ShowMenu();
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

        async Task CallApi()
        {
            //System.Diagnostics.Process.Start("mozroots", "--import --quiet");
            Login = await _api.GetSample();
        }
    }
}
