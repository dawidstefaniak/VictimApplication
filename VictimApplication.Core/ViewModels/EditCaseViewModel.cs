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
    public class EditCaseViewModel :MvxViewModel<CaseDto>
    {
        private readonly IApi _api;
        private readonly IUserDialogs _userDialogs;
        public EditCaseViewModel(IApi api, IUserDialogs userDialogs)
        {
            _api = api;
            _userDialogs = userDialogs;
        }
        private CaseDto currentcase;

        private int _caseId;
        public int CaseId
        {
            get { return _caseId; }
            set { SetProperty(ref _caseId, value); }
        }
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
        public  DateTime ReportDate
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
        private int _officerId;
        public int OfficerId
        {
            get { return _officerId; }
            set { SetProperty(ref _officerId, value); }
        }
        private int _typeOfCrimeId;
        public int TypeOfCrimeId
        {
            get { return _typeOfCrimeId; }
            set { SetProperty(ref _typeOfCrimeId, value); }
        }
        public IMvxCommand EditCaseCommand => new MvxAsyncCommand(EditCase);

        public async Task EditCase()
        {
            var CaseToEdit = new CaseDto
            {
                CaseId = CaseId,
                RefNumber = RefNumber,
                FirstName = FirstName,
                SecondName = SecondName,
                CaseStatus = CaseStatus,
                ReportDate = ReportDate,
                Address = Address,
                PhoneNumber = PhoneNumber,
                Email = Email,
                OfficerId = OfficerId,
                TypeOfCrimeId = TypeOfCrimeId
            };
            await _api.UpdateCase(CaseToEdit);
            Close(this);
            _userDialogs.Alert("Case updated!");
        }

        public override void Prepare(CaseDto parameter)
        {
            
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            currentcase = await _api.GetCaseById(currentcase.CaseId);
            UpdateFormWithCase();
        }

        public void Init(CaseDto parameter)
        {
            currentcase = parameter;
        }

        public void UpdateFormWithCase()
        {
            CaseId = currentcase.CaseId;
            RefNumber = currentcase.RefNumber;
            FirstName = currentcase.FirstName;
            SecondName = currentcase.SecondName;
            CaseStatus = currentcase.CaseStatus;
            ReportDate = currentcase.ReportDate;
            Address = currentcase.Address;
            PhoneNumber = currentcase.PhoneNumber;
            Email = currentcase.Email;
            OfficerId = currentcase.OfficerId;
            TypeOfCrimeId = currentcase.TypeOfCrimeId;
        }

    }
}
