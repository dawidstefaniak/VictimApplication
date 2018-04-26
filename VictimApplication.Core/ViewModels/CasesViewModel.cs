using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
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
        private IEnumerable<CaseDto> _listofcases;
//        private readonly IMvxNavigationService _navigationService;
        private MvxObservableCollection<CaseDto> _casesobservable = new MvxObservableCollection<CaseDto>();
        public CasesViewModel(IApi api, IMvxNavigationService NavigationService)
        {
            _api = api;
//            _navigationService = NavigationService;
        }

        public string Information
        {
            get { return _information; }
            set { SetProperty(ref _information, value); }
        }

        public MvxObservableCollection<CaseDto> casesobservable 
        {
            get { return _casesobservable; }
            set { SetProperty(ref _casesobservable, value); }
        }

        public IEnumerable<CaseDto> Listofcases
        {
            get { return _listofcases; }
            set { SetProperty(ref _listofcases, value); }
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
        public IMvxCommand DisplayMessagesCommand => new MvxCommand<CaseDto>((currentcase) => ShowViewModel<MessangerViewModel>(new {caseId = currentcase.CaseId}));


        public async Task GetCases()
        {
            //Data is userId parameter which will be send by API in get method
            try
            {
                Listofcases = await _api.GetListOfCasesForUser(user.UserId);

                foreach (var cases in Listofcases)
                {
                    casesobservable.Add(cases);
                }
            }
            catch(Exception ex)
            {
                _information = ex.Message;
            }
        }

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
