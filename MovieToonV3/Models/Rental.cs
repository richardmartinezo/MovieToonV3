//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieToonV3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
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