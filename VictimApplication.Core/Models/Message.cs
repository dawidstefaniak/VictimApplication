using System;
using SQLite;

namespace VictimApplication.Core.Models
{
    [Table(nameof(Message))]
    public class Message
    {
        [NotNull, PrimaryKey]
        public int MessageId { get; set; }

        [MaxLength(250)]
        public string MessageText { get; set; }

        public bool IsPoliceSender { get; set; }

        public Message()
        {
            MessageText = "";
        }

    }
}
