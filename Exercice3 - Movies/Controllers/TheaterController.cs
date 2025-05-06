using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Movies_Exercice3.Data;

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
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };
    
    [HttpGet]
    public string Get()
    {
        return JsonSerializer.Serialize(_context.Theater, _jsonOptions);
    }
    
}