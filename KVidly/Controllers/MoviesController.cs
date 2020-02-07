using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KVidly.Models;
using KVidly.ViewModels;

namespace KVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Tanhaji" };

            var customers = new List<Customer>
            {
                new Customer{Name = "customer1" },
                new Customer{Name = "customer2" }

            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
             return View(viewModel);

          
        }

        //public ActionResult Edit(int movieId)
        //{
        //    return Content("Id=" + movieId);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        [Route("movies/released/{year:regex(\\d{4}):range(1,2020)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year +"/"+ month);

        }

    }
}