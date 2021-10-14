using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieToonV3.Models;
using MovieToonV3.Models.ViewModels;


namespace MovieToonV3.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental
        public ActionResult Index()
        {
            List<RentalTable> lst;
            using (MovieToonV3.Models.OEAEntities oea = new OEAEntities())
            {
                lst = (from d in oea.Rentals
                       select new RentalTable
                       {
                           Id = d.Id,
                           Customer = d.Customer,
                           Movie = d.Movie,
                           PayMethod = d.PayMethod,
                           Membership = d.Membership,
                           PriceToPayWithDiscount = d.PriceToPayWithDiscount
                       }).ToList();
            }



            return View(lst);
        }
        public ActionResult NewRental()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewRental(Rental rentalNew)
        {
            MovieToonV3.Models.OEAEntities oea = new OEAEntities();
           var customertemp = oea.Customers.Where(cust=>cust.Name==rentalNew.Customer).FirstOrDefault();
           var movietemp = oea.Movies.Where(m=>m.Name==rentalNew.Movie).FirstOrDefault();
           var membershiptemp = oea.Memberships.Where(mem=>mem.Type==customertemp.Membership).FirstOrDefault();
            

            rentalNew.PriceToPayWithoutDiscount = movietemp.RentPrice;
            rentalNew.PriceToPayWithDiscount = movietemp.RentPrice*membershiptemp.Discount; 
            oea.Rentals.Add(rentalNew);
            oea.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult EditRental()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditRental(Rental rentalEdit)
        {
            MovieToonV3.Models.OEAEntities oea = new OEAEntities();
            //var customertemp = oea.Customers.Where(cust => cust.Name == rentalEdit.Customer).FirstOrDefault();
            //var movietemp = oea.Movies.Where(m => m.Name == rentalEdit.Movie).FirstOrDefault();
            //var membershiptemp = oea.Memberships.Where(mem => mem.Type == customertemp.Membership).FirstOrDefault();
            //rentalEdit.PriceToPayWithoutDiscount = movietemp.RentPrice;
            //rentalEdit.PriceToPayWithDiscount = movietemp.RentPrice * membershiptemp.Discount;
            
            //  oea.Rentals.Add(rentalEdit);
            oea.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}