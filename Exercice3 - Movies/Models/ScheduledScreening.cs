namespace Movies_Exercice3.Models;

public class ScheduledScreening
{
    public int Id { get; set; }
    public required Movie Movie { get; set; }
    public required ScreenRoom ScreenRoom { get; set; }
    public required DateTime StartTime { get; set; }
    public int ReservationsCount { get; set; }
}
