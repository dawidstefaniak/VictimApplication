using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class MessageViewModel : MvxViewModel<MessageDto>
    {
        private MessageDto currentMessage;
        private readonly IUserDialogs _userDialogs;
        private string messageText;

        public string MessageText
        {
            get => messageText;
            set => SetProperty(ref messageText, value);
        }

        public MessageDto CurrentMessage
        {
            get => currentMessage;
            set => SetProperty(ref currentMessage, value);
        }

        public MessageViewModel(IUserDialogs userDialogs)
        {
            _userDialogs = userDialogs;
        }

        public override void Prepare(MessageDto parameter)
        {
            throw new NotImplementedException();
        }

        public void Init(MessageDto parameter)
        {
            CurrentMessage = parameter;
            MessageText = parameter.MessageText;
        }
    }
}
