using System;
using System.Threading.Tasks;
using SQLite;

namespace VictimApplication.Core.Models
{
    [Table(nameof(User))]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(25), NotNull]
        public string Login { get; set; }

        [NotNull, MaxLength(25)]
        public string Password { get; set; }

        //P for Police, A for Admin, U for User
        [NotNull]
        public char UserType { get; set; }

        [NotNull, MaxLength(50)]
        public string Name { get; set; }

        public int AssignedPolice { get; set; }

        public bool isValid {get;set;}

        public User()
        {
            Login = "";
            Password = "";
            UserType = 'U';
            Name = "";
            isValid = false;
        }
    }
}
