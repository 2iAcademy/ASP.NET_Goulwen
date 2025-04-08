using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class MovieController : Controller
{
    public IActionResult Index()
    {
        var movies = new List<Movie>
        {
            new Movie {Id = 1, Title = "Iron Man", Director = "Iron Man"},
            new Movie {Id = 2, Title = "Matrix", Director = "The Dark"},
            new Movie {Id = 3, Title = "The Dark", Director = "Nolan"},
        };
        
        return View(movies);
    }
}
