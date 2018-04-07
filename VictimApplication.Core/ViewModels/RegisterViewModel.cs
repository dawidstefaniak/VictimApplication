using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class RegisterViewModel : MvxViewModel
    {
        private readonly IApi _api;
        public RegisterViewModel(IApi api)
        {
            _api = api;
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


        public IMvxCommand RegisterCommand => new MvxCommand(Register);
        public IMvxCommand BackCommand => new MvxCommand(BackToLogin);

        private void BackToLogin()
        {
            ShowViewModel<MenuViewModel>();
        }

        private void Register()
        {
            APISendRegisterRequest();
            ShowViewModel<LoginViewModel>();
        }

        private void APISendRegisterRequest()
        {

        }
    }
}