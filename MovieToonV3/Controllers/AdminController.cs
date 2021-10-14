using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieToonV3.Models;
using MovieToonV3.Models.ViewModels;

namespace MovieToonV3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            List<CustomerTable> lst;
            using (MovieToonV3.Models.OEAEntities oea = new OEAEntities()) {
                lst = (from d in oea.Customers
                           select new CustomerTable
                           {    Id= d.Id,
                                Name = d.Name,
                                Age = d.Age,
                                Email = d.Email,
                                Membership = d.Membership,
                                UID = d.UID
                           }).ToList();
            }



            return View(lst) ;
        }
        public ActionResult NewCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCustomer(Customer customerEdit)
        {
            MovieToonV3.Models.OEAEntities oea = new OEAEntities();
            oea.Customers.Add(customerEdit);
            oea.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            MovieToonV3.Models.OEAEntities oea = new OEAEntities();
            var cstmer = oea.Customers.Where(c=>c.Id==id).First();

            return View(cstmer);
        }
        [HttpPost]
        public ActionResult Edit(Customer customerEdit)
        {
            MovieToonV3.Models.OEAEntities oea = new OEAEntities();
            var cstmer = oea.Customers.Find(customerEdit.Id);
            cstmer.Membership = customerEdit.Membership;
            cstmer.Name = customerEdit.Name;
            cstmer.Age = customerEdit.Age;
            cstmer.Email = customerEdit.Email;
            cstmer.Telephone = customerEdit.Telephone;
            cstmer.UID = customerEdit.UID;
            oea.Entry(cstmer).State= System.Data.Entity.EntityState.Modified;
            oea.SaveChanges();
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Remove(Customer customerEdit)
        {
            MovieToonV3.Models.OEAEntities oea = new OEAEntities();
            var cstmer = oea.Customers.Find(customerEdit.Id);
            oea.Customers.Remove(cstmer);
            oea.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}