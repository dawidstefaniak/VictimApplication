using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class CasesViewModel : MvxViewModel
    {
        private LoggedUserDto user = new LoggedUserDto();
        private readonly IApi _api;
        private string _information;

        public CasesViewModel(IApi api)
        {
            _api = api;
        }

        public string Information
        {
            get { return _information; }
            set { SetProperty(ref _information, value); }
        }

        public override async Task Initialize()
        {
            Information = user.UserId.ToString();
            await GetCases();
            await base.Initialize();
            // do something with _initialParameter
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);
        public IMvxCommand LoadCasesCommand => new MvxAsyncCommand(GetCases);

        public async Task GetCases()
        {
            //Data is userId parameter which will be send by API in get method
            var data = new Dictionary<string, object>
            {
                {"userId", user.UserId.ToString()}
            };
            var list = await _api.GetListOfCasesForUser(data);

        }

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
