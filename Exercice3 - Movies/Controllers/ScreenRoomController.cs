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
public class ScreenRoomController(AppDbContext context)
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
        return JsonSerializer.Serialize(_context.ScreenRoom.Include(s => s.Theater), _jsonOptions);
    }
    
    [HttpGet]
    [Route("{Id}")]
    public string GetById(int id)
    {
        return JsonSerializer.Serialize(_context.ScreenRoom.Include(s => s.Theater).Where(t => t.Id == id).FirstOrDefault(), _jsonOptions);
    }
}