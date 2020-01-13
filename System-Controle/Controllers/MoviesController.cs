using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System_Controle.Models;
using System_Controle.ViewModels;
using System.Data.Entity;

namespace System_Controle.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _DbContext = new ApplicationDbContext();
        public MoviesController()//ctor
        {
            _DbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _DbContext.Dispose();
            base.Dispose(disposing);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1,  Name="Shrek!"},
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        // GET: Movies/IndexMovie
        public ActionResult Movies()
        {
            var movie = _DbContext.Movies.Include(m => m.Genre).ToList(); //GetMovies();
            if (User.IsInRole(RoleName.canManageMovies))
            {
               
                return View(movie);
            }
            else
                return View("ReadOnlyMovies", movie);
            
        }


        public ActionResult Details(int id)
        {
            var movie = _DbContext.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id); //GetMovies();
            return View(movie);
        }
        [Authorize(Roles = RoleName.canManageMovies)]
        public ActionResult New()
        {
            var genre = _DbContext.Genres.ToList();
            MovieFormViewModel viewModel = new MovieFormViewModel()
            {
                Genres = genre
            };

            return View("MovieForm", viewModel);
        }
        public ActionResult Edit(int id)
        {
            var movie = _DbContext.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            var genre = _DbContext.Genres.ToList();
            MovieFormViewModel viewModel = new MovieFormViewModel(movie)
            {
                Genres = genre
            };
            if (movie == null)
                return HttpNotFound();
            else
                return View("MovieForm", viewModel);
        }
        // GET: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                MovieFormViewModel viewModel = new MovieFormViewModel(movie)
                {

                    Genres = _DbContext.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }
            else
            {
                if (movie.Id == 0)
                    _DbContext.Movies.Add(movie);
                else
                {
                    var movieInDb = _DbContext.Movies.Single(c => c.Id == movie.Id);
                    //TryUpdateModel(customerInDb,"", new string[] { "Email","Date"});
                    //AutoMapper//UpdateCustomerDto
                    //Mapper.Map(customer,customerInDb);
                    movieInDb.Name = movie.Name;
                    movieInDb.Genre = movie.Genre;
                    movieInDb.NumberInStock = movie.NumberInStock;
                    movieInDb.ReleaseDate = movie.ReleaseDate;

                }
                try
                {
                    _DbContext.SaveChanges();
                }
                catch (DbEntityValidationException ex)//using System.Data.Entity.Validation; DbEntityValidationException
                {
                    Console.WriteLine(ex);
                }

                return RedirectToAction("Movies", "Movies");
            }

        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {

                Name = "Shrek!"
            };
            var customers = new List<Customer>()
            {
                new Customer{Name="Isam"},
                new Customer{Name="Muhammad"}
            };
            var randomMovieViewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(randomMovieViewModel);
        }
    }
}