namespace Movies_Exercice3.Models;

public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required List<Genre> Genre { get; set; }
    public required DateOnly ReleaseDate { get; set; }
    public required Person Director { get; set; }
    public required List<Person> Actors { get; set; }
}
