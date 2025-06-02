using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class MovieController : Controller
{
  private readonly AppDbContext _context;
  public MovieController(AppDbContext context)
  {
    _context = context;
  }
  public IActionResult Index()
  {
    var movies = _context.Movie.ToList();
    return View(movies);
  }

  public IActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Create(Movie movie)
  {
    if (ModelState.IsValid)
    {
      _context.Movie.Add(movie);
      _context.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
    return View(movie);
  }
}
