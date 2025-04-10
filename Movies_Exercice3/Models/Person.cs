namespace Movies_Exercice3.Models;

public class Person
{
    public int Id { get; set; }
    public required string FullName { get; set; }
    public DateOnly DateOfBirth { get; set; }
}