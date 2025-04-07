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
    
    [HttpGet]
    [Route("/api/[controller]/salut")]
    public string Salut()
    {
        return "Salut monde!";
    }
    
    [HttpGet]
    [Route("/api/[controller]/personne/{nom}")]
    public string BonjourNom(string? nom)
    {
        return $"Bonjour, {nom}!";
    }
    
    [HttpGet]
    [Route("/api/[controller]/add/{a}/{b}")]
    public string Add(int? a, int? b)
    {
        return $"Résultat: {a + b}!";
    }
    
    [HttpGet]
    [Route("/api/[controller]/heure")]
    public string GetHeure()
    {
        return $"Il est {DateTime.Now.TimeOfDay}!";
    }
    
    [HttpGet]
    [Route("/api/[controller]/majeur/{age}")]
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
