﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VictimApplication.Core.Models
{
    public class MessageDto
    {
        public int MessageId { get; set; }

        public int CaseId {get;set;}

        public int SenderUserId { get; set; }

        public int ReceiverUserId { get; set; }

        public string MessageText { get; set; }

        public DateTime SentDate { get; set; }
    }
}
