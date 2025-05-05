using Microsoft.AspNetCore.Mvc;

namespace Exercice1.Controllers;


[ApiController]
[Route("/api/[controller]")]
public class BonjourController
{
    [HttpGet]
    public string Get()
    {
        return "Bonjour monde!";
    }
    
    [HttpGet("/api/[controller]/salut")]
    public string Salut()
    {
        return "Salut monde!";
    }
    
    [HttpGet("/api/[controller]/personne/{nom}")]
    public string BonjourNom(string? nom)
    {
        return $"Bonjour, {nom}!";
    }
    
    [HttpGet("/api/[controller]/add/{a}/{b}")]
    public string Add(int? a, int? b)
    {
        return $"Résultat: {a + b}!";
    }
    
    [HttpGet("/api/[controller]/heure")]
    public string GetHeure()
    {
        return $"Il est {DateTime.Now.TimeOfDay}!";
    }
    
    [HttpGet("/api/[controller]/majeur/{age}")]
    public string IsMajeur(int? age)
    {
        if (age < 18)
        {
            return $"Mineur!";
        }
        else
        {
            return $"Majeur";
        }
    }
}
