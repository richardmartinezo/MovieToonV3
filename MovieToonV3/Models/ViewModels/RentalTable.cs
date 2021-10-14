using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieToonV3.Models.ViewModels
{
    public class RentalTable
    {
        public long Id { get; set; }
        public string Movie { get; set; }
        public string Membership { get; set; }
        public Nullable<double> PriceToPayWithoutDiscount { get; set; }
        public Nullable<double> PriceToPayWithDiscount { get; set; }
        public string PayMethod { get; set; }
        public string Customer { get; set; }
    }
}