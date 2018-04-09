using System.Threading.Tasks;
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
        public RegisterViewModel(IApi api, IMvxJsonConverter jsonConverter)
        {
            _api = api;
            _jsonConverter = jsonConverter;
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
            var UserForCreation = new UserForCreationDto
            {
                UserName = Login,
                Password = this.Password,
                FirstName = this.Firstname,
                SecondName = this.Surname
            };

            await _api.CreateUser(UserForCreation);

            Close(this);
        }
    }
}