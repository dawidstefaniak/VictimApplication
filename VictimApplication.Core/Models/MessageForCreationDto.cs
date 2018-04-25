using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VictimApplication.Core.Models
{
    public class MessageForCreationDto
    {
        public string MessageText { get; set; }
        public int CaseId {get;set;}
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }
    }
}
