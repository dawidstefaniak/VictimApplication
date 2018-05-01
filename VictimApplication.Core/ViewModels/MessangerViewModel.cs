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
        private LoggedUserDto currentuser = new LoggedUserDto();
        private IEnumerable<MessageDto> messagesList;

        //Messagetosend is only private
        private MessageForCreationDto messagetosend;
        private MvxObservableCollection<MessageDto> messagesObservable = new MvxObservableCollection<MessageDto>();

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
        public IMvxCommand DisplayMessageCommand => new MvxCommand<MessageDto>((currentmessage) => ShowViewModel<MessageViewModel>(currentmessage));
        public IMvxCommand SendMessageCommand => new MvxAsyncCommand(SendMessage);

        public override void Prepare(CaseDto parameter)
        {

        }

        public override async Task Initialize()
        {
            await GetMessages();
            await base.Initialize();
        }

        public void Init(CaseDto parameter)
        {
            currentCase = parameter;
        }

        public async Task GetMessages()
        {
            MessagesObservable.Clear();
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

        public async Task SendMessage()
        {
            

            if (currentuser.UserId == currentCase.OfficerId)
            {
                messagetosend = new MessageForCreationDto
                {
                    MessageText = Message,
                    CaseId = currentCase.CaseId,
                    IsPoliceSender = true
                };
            }
            else
            {
                messagetosend = new MessageForCreationDto
                {
                    MessageText = Message,
                    CaseId = currentCase.CaseId,
                    IsPoliceSender = false
                };
            }
            try
            {
                await _api.SendMessage(messagetosend);
                await RefreshForm();

            }
            catch
            {
                
            }
        }

		private void ShowMenu()
        {
            Close(this);
        }
        private async Task RefreshForm()
        {
            Message = null;
            await GetMessages();

        }



    }
}
