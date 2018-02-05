using System;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.Core.ViewModels
{
    public class MenuViewModel : MvxViewModel
    {
        public IMvxCommand ShowPoliceDetailsCommand => new MvxCommand(ShowPoliceDetails);

        private void ShowPoliceDetails()
        {
            ShowViewModel<PoliceDetailsViewModel>();
        }
        public IMvxCommand ShowInformationCommand => new MvxCommand(ShowInformation);

        private void ShowInformation()
        {
            ShowViewModel<InformationViewModel>();
        }
        public IMvxCommand ShowMessangerCommand => new MvxCommand(ShowMessanger);

        private void ShowMessanger()
        {
            ShowViewModel<MessangerViewModel>();
        }

        public IMvxCommand ShowLoginCommand => new MvxCommand(ShowLogin);

        private void ShowLogin()
        {
            ShowViewModel<LoginViewModel>();
        }

    }
}
