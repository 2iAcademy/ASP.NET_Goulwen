namespace Movies_Exercice3.Models;

public class Person
{
    public int Id { get; set; }
    public required string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Movie> MoviesDirected { get; set; }
    public List<Movie> MoviesPlayedIn { get; set; }
}
