using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieReviewApp.Data;
using MovieReviewApp.Models;
using System.Diagnostics;

namespace MovieReviewApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            var movies = _context.Movie.ToList();
            var reviews = _context.Review.ToList();

            // You can now pass these lists to your view or use them as needed

            ViewData["Movies"] = movies;
            ViewData["Reviews"] = reviews;
            string[] Imagearray = {"sorcerer'sstone", "superbad", "Pokiri_movie_poster", "oppenheimer"  };
            ViewData["ImageArray"] = Imagearray;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
