using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;

namespace VictimApplication.Core.ViewModels
{
    public class CaseViewModel : MvxViewModel
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
            Information = user.UserId.ToString();
            await base.Initialize();
            // do something with _initialParameter
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
