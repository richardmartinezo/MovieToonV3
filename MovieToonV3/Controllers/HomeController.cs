using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieToonV3.Models;

namespace MovieToonV3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(MovieToonV3.Models.User loginUser)
        {
            using (OEAEntities oEAEntities = new OEAEntities()) {
                var userDetail = oEAEntities.Users.Where(x=>x.Username == loginUser.Username && x.Password == loginUser.Password);
                if (userDetail == null)
                {

                    loginUser.loginMessage = "Wrong username or password";
                    return View("Index", loginUser);
                }
                else {

                    if (userDetail.First().Role.Equals("Administrator"))
                    {
                        Session["userID"] = userDetail.FirstOrDefault().Username;
                        //  Session["userID"] = userDetail.FirstOrDefault().Username;
                        return RedirectToAction("Index", "Admin");
                    }
                    else {
                        Session["userID"] = userDetail.FirstOrDefault().Username;
                        //  Session["userID"] = userDetail.FirstOrDefault().Username;
                        return RedirectToAction("Index", "Employee");
                    }
                   
                }
            
            
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}