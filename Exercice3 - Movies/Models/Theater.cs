using System.Text.Json.Serialization;

namespace Movies_Exercice3.Models;

public class Theater
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<ScreenRoom> ScreenRooms { get; set; }
}
