using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class MessangerViewModel : MvxViewModel<CaseDto>
    {
        private string message;
        private readonly IApi _api;
        private CaseDto currentCase;
        private IEnumerable<MessageDto> messagesList;
        private MvxObservableCollection<MessageDto> messagesObservable = new MvxObservableCollection<MessageDto>();

        private int caseid;
        public string Message 
        {
            get => message;
            set { SetProperty(ref message, value); }
        }

        public MvxObservableCollection<MessageDto> MessagesObservable
        {
            get => messagesObservable;
            set { SetProperty(ref messagesObservable, value); }
        }

        public IEnumerable<MessageDto> MessagesList
        {
            get => messagesList;
            set { SetProperty(ref messagesList, value); }
        }

        public MessangerViewModel(IApi api)
        {
            _api = api;
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);
        public IMvxCommand GetMessagesCommand => new MvxAsyncCommand(GetMessages);

        public override void Prepare(CaseDto parameter)
        {

        }

        public override async Task Initialize()
        {
            await base.Initialize();
            await GetMessages();
        }

        public void Init(CaseDto parameter)
        {
            currentCase = parameter;
        }

        public async Task GetMessages()
        {
            try
            {
                //
                MessagesList = await _api.GetListOfMessagesForCase(currentCase.CaseId);
                foreach(var messages in messagesList)
                {
                    MessagesObservable.Add(messages);
                }
            }
            catch(Exception ex)
            {
                //TODO
            }
        }

		private void ShowMenu()
        {
            Close(this);
        }



    }
}
