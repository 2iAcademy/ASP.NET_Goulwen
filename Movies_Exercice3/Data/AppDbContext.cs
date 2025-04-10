using Microsoft.EntityFrameworkCore;
using Movies_Exercice3.Models;

namespace Movies_Exercice3.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<Cinema> Cinema => Set<Cinema>();
}