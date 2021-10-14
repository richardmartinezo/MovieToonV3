using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieToonV3.Models.ViewModels
{
    public class MovieTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> RentPrice { get; set; }
    }
}