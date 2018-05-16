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
		public bool IsPoliceSender { get; set; }
    }
}
