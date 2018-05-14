using System;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.ViewModels;
using VictimApplication.Core.Models;
using Acr.UserDialogs;

namespace VictimApplication.Core.ViewModels
{
    public class MenuPoliceViewModel : MvxViewModel
    {
		private LoggedUserDto user = new LoggedUserDto();

		private readonly IUserDialogs _dialogs;

		public MenuPoliceViewModel(IUserDialogs dialogs)
		{
			_dialogs = dialogs;
		}

        public IMvxCommand ShowMessangerCommand => new MvxCommand(ShowMessanger);

        private void ShowMessanger()
        {
            ShowViewModel<MessangerViewModel>();
        }

        public IMvxCommand ShowLoginCommand => new MvxCommand(ShowLogin);

        private void ShowLogin()
        {
            Close(this);
        }
        public IMvxCommand ShowCasesCommand => new MvxCommand(ShowCasesLogin);

        private void ShowCasesLogin()
        {
            ShowViewModel<CasesForModifyingViewModel>();
        }

		public IMvxCommand ShowAddCaseCommand => new MvxCommand(ShowAddCase);

        private void ShowAddCase()
		{
			ShowViewModel<AddCaseViewModel>();
		}

		public IMvxCommand EditUserCommand => new MvxCommand(EditUser);

        private void EditUser()
		{
			if (user.UserType == "A")
			{
				ShowViewModel<UserListViewModel>();
			}
			else _dialogs.Alert("You are not logged as an Admin!");
		}
    }
}
