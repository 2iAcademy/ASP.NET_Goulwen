using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies_Exercice3.Data;

namespace Movies_Exercice3.Controllers;

[EnableCors]
[ApiController]
[Route("api/[controller]")]
public class ScreenRoomController(AppDbContext context)
{
    private readonly AppDbContext _context = context;
    private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };
    
    [HttpGet]
    public string Get()
    {
        var screenrooms = _context.ScreenRoom.Select(s => new
        {
            s.Id,
            s.Name,
            s.Capacity,
            s.ScheduledScreenings,
            Theater = new { s.Theater.Id, s.Theater.Name }
        });
        return JsonSerializer.Serialize(screenrooms, _jsonOptions);
    }
    
    [HttpGet]
    [Route("{Id}")]
    public string GetById(int id)
    {
        return JsonSerializer.Serialize(_context.ScreenRoom.Include(t => t.Theater).Where(t => t.Id == id), _jsonOptions);
    }
}