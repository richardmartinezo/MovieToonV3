using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MovieToonV3.Models;
using MovieToonV3.Models.ViewModels;


namespace MovieToonV3.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            List<MovieTable> lst;
            using (MovieToonV3.Models.OEAEntities oea = new OEAEntities())
            {
                lst = (from d in oea.Movies
                       select new MovieTable
                       {
                           Id = d.Id,
                           Name = d.Name,
                           RentPrice = d.RentPrice,
                           Description = d.Description
                           
                       }).ToList();
            }



            return View(lst);
        }
    }
}