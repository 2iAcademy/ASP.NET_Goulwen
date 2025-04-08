using Microsoft.AspNetCore.Mvc;
using Exercice2.Models;

namespace Exercice2.Controllers;

public class BookController : Controller
{
    public IActionResult Index()
    {
        List<Book> books = new List<Book>
        {
            new Book{Id = 0, Title = "Le Petit Prince", Author = "Antoine de Saint-Exupéry", Year = 1998},
            new Book{Id = 1, Title = "1984", Author = "George Orwell", Year = 1999},
            new Book{Id = 2, Title = "L'Étranger", Author = "Author 1", Year = 2000},
            new Book{Id = 3, Title = "Harry Potter à l'école des sorciers", Author = "J.K. Rowling", Year = 2001}
        };
        return View(books);
    }
}