using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;

namespace VictimApplication.Core.ViewModels
{
    public class CasesViewModel : MvxViewModel
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
            var userek = typeof(LoggedUserDto).GetField("UserId");
            await base.Initialize();
            Information = userek.GetValue(null).ToString();
            // do something with _initialParameter
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
