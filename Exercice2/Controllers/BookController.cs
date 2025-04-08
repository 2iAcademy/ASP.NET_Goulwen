using Microsoft.AspNetCore.Mvc;
using Exercice2.Models;

namespace Exercice2.Controllers;

public class BookController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}