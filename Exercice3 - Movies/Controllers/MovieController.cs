using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies_Exercice3.Data;

namespace Movies_Exercice3.Controllers;

[EnableCors]
[ApiController]
[Route("api/[controller]")]
public class MovieController(AppDbContext context)
{
    private readonly AppDbContext _context = context;
    private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        ReferenceHandler = ReferenceHandler.IgnoreCycles 
    };
    
    [HttpGet]
    public string Get()
    {
        return JsonSerializer.Serialize(_context.Movie
            .Include(m => m.Director)
            .Include(m => m.Genres)
            , _jsonOptions);
    }
    
    [HttpGet]
    [Route("{Id}")]
    public string GetById(int id)
    {
        return JsonSerializer.Serialize(_context.Movie
            .Include(m => m.Director)
            .Include(m => m.Actors)
            .Include(m => m.Genres)
            .FirstOrDefault(t => t.Id == id)
            , _jsonOptions);
    }
}