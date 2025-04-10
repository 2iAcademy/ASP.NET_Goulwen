namespace Movies_Exercice3.Models;

public class ScreenRoom
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Capacity { get; set; }
    public required int MovieTheaterId { get; set; }
    public List<ScheduledScreening> ScheduledScreenings { get; set; } = [];
}