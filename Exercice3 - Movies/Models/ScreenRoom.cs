using System.Text.Json.Serialization;

namespace Movies_Exercice3.Models;

public class ScreenRoom
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Capacity { get; set; }
    public int TheaterId { get; set; }
    public Theater Theater { get; set; } = null!;
    public List<ScheduledScreening> ScheduledScreenings { get; set; } = [];

}
