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

        [NotNull]
        public int SenderId { get; set; }

        [NotNull]
        public int ReceiverId { get; set; }

        public Message()
        {
            ReceiverId = 0;
            SenderId = 0;
            MessageText = "";
        }
    }
}
