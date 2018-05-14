using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VictimApplication.Core.Models
{
    public class UserListToReturnDto
    {
        public int userId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email {get;set;}
        public string UserType {get;set;}
		public string NameToReturn { get => $"{FirstName} {SecondName}"; }
		public string UserTypeToReturn
		{
			get
			{
				if(UserType == "U")
				{
					return "User";
				}
				if (UserType == "P")
				{
					return "Police";
				}
				return "Admin";
			}	
		}
    }
}

