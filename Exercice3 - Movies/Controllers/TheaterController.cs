using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies_Exercice3.Data;
using Movies_Exercice3.Models;

namespace Movies_Exercice3.Controllers;

[EnableCors]
[ApiController]
[Route("api/[controller]")]
public class TheaterController(AppDbContext context)
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
        /* Exemple de projection LINQ pour renvoyer seulement certains champs
        var theaters = _context.Theater.Select(t => new
        {
            t.Id,
            t.Name,
            ScreenRooms = t.ScreenRooms.Select(s=> new {s.Id, s.Name})
        }); */
        
        return JsonSerializer.Serialize(_context.Theater.Include(t => t.ScreenRooms),_jsonOptions);
    }
    
    [HttpGet]
    [Route("{Id}")]
    public string GetById(int id)
    {
        return JsonSerializer.Serialize(_context.Theater.Include(t => t.ScreenRooms).FirstOrDefault(t => t.Id == id), _jsonOptions);
    }
    
}