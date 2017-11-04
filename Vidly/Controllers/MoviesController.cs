using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();


            return View(movies);
        }

        public ActionResult Details(int Id)
        {
            var movies = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == Id);
            if (movies == null)
                return HttpNotFound();
            return View(movies);
        }


        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            movie.AddingDate = DateTime.Now;
            if (movie.Id == 0)
                _context.Movies.Add(movie);

            else
            {
                var MovieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                MovieInDb.Name = movie.Name;
                MovieInDb.GenreId = movie.GenreId;
                MovieInDb.ReleaseDate = movie.ReleaseDate;
                MovieInDb.AmountInStock = movie.AmountInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult New()
        {
            var moviegenres = _context.Genres.ToList();
            var movieViewModel = new MovieViewModel
            {
                Genres = moviegenres
            };
            return View("MovieForm", movieViewModel);
        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();

            var genres = _context.Genres.ToList();
            var movieViewModel = new MovieViewModel
            {
                Movie = movie,
                Genres = genres
            };
            return View("MovieForm", movieViewModel);
        }
    }
}