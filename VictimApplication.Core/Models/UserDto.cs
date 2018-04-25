
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VictimApplication.Core.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public virtual ICollection<Message> MessagesSent { get; set; } = new List<Message>();

        public virtual ICollection<Message> MessagesReceived { get; set; } = new List<Message>();
    }
}

