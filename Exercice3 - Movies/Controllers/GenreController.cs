using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies_Exercice3.Data;
using Movies_Exercice3.Models;

namespace Movies_Exercice3.Controllers;

[EnableCors]
[ApiController]
[Route("api/[controller]")]
public class GenreController(AppDbContext context) : Controller
{
    private readonly AppDbContext _context = context;
    
    [HttpGet]
    public async Task<ActionResult<List<Genre>>> Get()
    {
        return await _context.Genre.Include(g => g.Movies).ToListAsync();
    }
    
    [HttpGet]
    [Route("{Id}")]
    public async Task<ActionResult<Genre>> GetById(int id)
    {
        return await _context.Genre
            .Include(g => g.Movies)
            .ThenInclude(m => m.Director)
            .FirstOrDefaultAsync(t => t.Id == id) ?? (ActionResult<Genre>) NotFound();
    }

    [HttpPost]
    public async Task<ActionResult<Genre>> Post(Genre genre)
    {
        _context.Genre.Add(genre);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = genre.Id }, genre);
    }
    
    [HttpPut]
    [Route("{Id}")]
    public async Task<ActionResult<Genre>> Put(int id, Genre updatedGenre)
    {
        var genre = await _context.Genre.FindAsync(id);
        if (genre == null)
        {
            return NotFound();
        }// TODO
        genre = updatedGenre;
        await _context.SaveChangesAsync();
        return NoContent();
    }
    
    [HttpDelete]
    [Route("{Id}")]
    public async Task<ActionResult<Genre>> Delete(int id)
    {
        var genre = await _context.Genre.FindAsync(id);
        if (genre == null)
        {
            return NotFound();
        }
        _context.Genre.Remove(genre);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
