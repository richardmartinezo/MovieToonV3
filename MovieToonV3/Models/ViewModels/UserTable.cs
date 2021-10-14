using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MovieToonV3.Models.ViewModels
{
    public class UserTable
    {
        public int Id { get; set; }
       
        public string Username { get; set; }
        
        public string Password { get; set; }
        public string Role { get; set; }

        public string LoginMessage;
    }
}