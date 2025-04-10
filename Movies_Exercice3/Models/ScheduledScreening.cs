namespace Movies_Exercice3.Models;

public class ScheduledScreening
{
    public int Id { get; set; }
    public required int MovieId { get; set; }
    public required int ScreenRoomId { get; set; }
    public required DateTime StartTime { get; set; }
    public int ReservationsCount { get; set; }
}
