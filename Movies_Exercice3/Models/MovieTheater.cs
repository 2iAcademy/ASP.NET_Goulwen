namespace Movies_Exercice3.Models;

public class MovieTheater
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<ScreenRoom> ScreenRooms { get; set; } = [];
}