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
    [Route("/api/[controller]/personne/{nom?}")]
    public string BonjourNom(string? nom)
    {
        return $"Bonjour, {nom}!";
    }
}
