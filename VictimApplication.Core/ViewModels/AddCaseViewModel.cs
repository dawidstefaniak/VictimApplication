using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class AddCaseViewModel : MvxViewModel
    {
        private readonly IApi _api;
        private readonly IUserDialogs _userDialogs;
		private LoggedUserDto user = new LoggedUserDto();

        public AddCaseViewModel(IApi api, IUserDialogs userDialogs)
        {
            _api = api;
            _userDialogs = userDialogs;
        }

		private CaseDto currentcase;
        
        private string _refNumber;
        public string RefNumber
        {
            get { return _refNumber; }
            set { SetProperty(ref _refNumber, value); }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        private string _secondName;
        public string SecondName
        {
            get { return _secondName; }
            set { SetProperty(ref _secondName, value); }
        }
        private string _caseStatus;
        public string CaseStatus
        {
            get { return _caseStatus; }
            set { SetProperty(ref _caseStatus, value); }
        }
        private DateTime _reportDate;
        public DateTime ReportDate
        {
            get { return _reportDate; }
            set { SetProperty(ref _reportDate, value); }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        public int OfficerId
        {
			get { return user.UserId; }
        }
        private string _typeOfCrime;
        public string TypeOfCrime
        {
            get { return _typeOfCrime; }
            set { SetProperty(ref _typeOfCrime, value); }
        }
		public IMvxCommand AddCaseCommand => new MvxAsyncCommand(AddCase);

		public async Task AddCase()
		{
			var CaseToAdd = new CaseForCreationDto
			{
				RefNumber = RefNumber,
				FirstName = FirstName,
				SecondName = SecondName,
				CaseStatus = CaseStatus,
				ReportDate = ReportDate,
				Address = Address,
				PhoneNumber = PhoneNumber,
				Email = Email,
				OfficerId = OfficerId,
				TypeOfCrime = TypeOfCrime
			};

			await _api.CreateCase(CaseToAdd);
			Close(this);
			_userDialogs.Alert("Case Added!");
		}

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public void Init(CaseDto parameter)
        {
            currentcase = parameter;
        }

    }
}
