using System;
namespace VictimApplication.Core.Models
{
    public class LoggedUserDto
    {
        //This class is saving userId and userType as static. It has to be done in 
        //that way, because Refit is using public variables which cannot be static.
        private static int userId;
        private static string userType;
        public int UserId { get => userId; set => userId = value; }
        public string UserType { get => userType; set => userType = value;}
    }
}
