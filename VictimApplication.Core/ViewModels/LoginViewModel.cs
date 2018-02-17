using System;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.ViewModels;
using System.Windows.Input;
using VictimApplication.Core.Models;

namespace VictimApplication.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
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

        private void LoginToMenu()
        {
            if (_user.IsValid())
            {
                ShowMenu();
            }
        }

        public void Init (User user = null)
        {
            _user = user == null ? new User() : user;
            RaiseAllPropertiesChanged();
        }

        private void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }
    }
}
