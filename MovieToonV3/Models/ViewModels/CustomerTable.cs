using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieToonV3.Models.ViewModels
{
    public class CustomerTable
    {
        public int Id { get; set; }
        public string UID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Membership { get; set; }
    }
}