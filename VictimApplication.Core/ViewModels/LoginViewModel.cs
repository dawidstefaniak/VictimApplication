using System;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _login = "Login";
        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _password = "Password";
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        private void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }
    }
}
