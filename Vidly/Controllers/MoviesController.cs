//using System.Collections.Generic;
//using System.Web.Mvc;
//using Vidly.Models;

//namespace Vidly.Controllers
//{
//    public class MoviesController : Controller
//    {
//        GET: Movies
//        public ActionResult Random()
//        {
//            var movie = new Movie() { Name = "Shrek!" };


//            //return Content("hey joao");
//            //return EmptyResult();
//            //return RedirectToAction("Index", )
//            //return HttpNotFound();


//            var customers = new List<Customer>
//            {
//                new Customer() {Name = "Customer1"},
//                new Customer() {Name = "Customer2"}
//            };


//            var viewModel = new RandomMoviewViewModel()
//            {
//                Movie = movie,
//                Customer = customers
//            };

//            return View(viewModel);


//        }







//        public ActionResult Edit(int id)
//        {
//            return Content("ID=" + id);
//        }
//        //movie
//        public ActionResult Index(int? pageIndex, string sorteBy)
//        {
//            if (!pageIndex.HasValue)
//                pageIndex = 1;
//            if (String.IsNullOrWhiteSpace(sorteBy))
//                sorteBy = "name";
//            return Content($"pageIndex={pageIndex}&sorteBy={sorteBy}");


//             public ViewResult Index()
//        {
//            var movies = GetMovies();

//            return Vew(movies);
//        }

//        private IEnumerable<Movie> GetMovies()
//        {
//            return new List<Movie>
//                {
//                    new Movie { Id = 1, Name = "Shrek" },
//                    new Movie { Id = 2, Name = "Wall-e" }
//               };
//        }
//    }

//    //URL pattern with the regex (regular expressions)                                        
//    [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
//    public ActionResult ByReleasedDate(int year, int month)
//    {
//        return Content(year + "/" + month);
//    }
//}



//}


using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMoviewViewModel
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);
        }
    }
}