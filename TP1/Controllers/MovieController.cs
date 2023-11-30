using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name =
            "movie 1"
            };
            List<Movie> movies = new List<Movie>()
            {
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
            };
            return View(movies);
        }




        public IActionResult Edit(int id)
        {
            return Content("TEST ID" + id);
        }
        [HttpGet]
        [Route("Movie/released/{year}/{month}")]
        public IActionResult ByRelease(int year, int month)
        {
            string content = $"Contenu pour l'année {year} et le mois {month}";
            return Content(content);
        }


        public IActionResult MCustomer()
        {
            Movie movie = new Movie { Name = "star warsss" };

            List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 8, Name = "Sabaa" },
            new Customer { Id = 9, Name = "Emna" }
        };
            CustomerMovie cm = new CustomerMovie(movie, customers);

            return View(cm);
        }
    }
}
