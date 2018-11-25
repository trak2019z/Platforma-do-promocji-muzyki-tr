﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platforma.Models; // Żeby mieć moliwość wywoływania z klas modelu
using Platforma.ViewModel;

namespace Platforma.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Terminator" }; // Użycie pola Name z Models/Movie dzięki using Platforma.Models
            var customers = new List<Customer>
            {
                new Customer { Name = "Cust1"},
                new Customer { Name = "Cust2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
           // ViewData["Movie"] = movie;
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]  //Reguła routingu pisana w nowy sposób

     /*  public ActionResult Edit(int id)
        {
            return Content("id=" + id);

        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex = {0} &sortBy= {1}", pageIndex, sortBy));

        }*/
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }



       

    }
}