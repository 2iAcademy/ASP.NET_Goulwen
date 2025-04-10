using Microsoft.EntityFrameworkCore;
using Movies_Exercice3.Models;

namespace Movies_Exercice3.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Theater> Theater => Set<Theater>();
    public DbSet<ScreenRoom> ScreenRoom => Set<ScreenRoom>();
    public DbSet<ScheduledScreening> ScheduledScreening => Set<ScheduledScreening>();
    public DbSet<Movie> Movie => Set<Movie>();
    public DbSet<Genre> Genre => Set<Genre>();
    public DbSet<Person> Person => Set<Person>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
