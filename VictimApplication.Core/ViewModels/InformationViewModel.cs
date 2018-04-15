﻿using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using VictimApplication.Core.Models;

namespace VictimApplication.Core.ViewModels
{
    public class InformationViewModel : MvxViewModel
    {
        private LoggedUserDto user = new LoggedUserDto();
        private string _information;

        public string Information
        {
            get { return _information; }
            set { SetProperty(ref _information, value); }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            Information = user.UserId.ToString();
            // do something with _initialParameter
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
