using Microsoft.AspNetCore.Mvc;
using MoviesMvc.Models;
using MoviesMvc.Views.Movies;

namespace MoviesMvc.Controllers
{
    public class MoviesController : Controller
    {
        readonly DataService dataService;

        public MoviesController(DataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {

            IndexVM[] model = dataService.GetAllMovies();

            return View(model);
        }

        [HttpGet("/Details/{id}")]
        public IActionResult Details(int id)
        {
            DetailsVM model = dataService.GetMovieById(id);

            return View(model);
        }

        [HttpGet("/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Create")]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View();

            dataService.AddMovie(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
