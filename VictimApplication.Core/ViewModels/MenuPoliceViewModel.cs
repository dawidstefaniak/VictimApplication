using System;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.Core.ViewModels
{
    public class MenuPoliceViewModel : MvxViewModel
    {
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
    }
}
