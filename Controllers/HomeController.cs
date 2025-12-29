using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public string Index()
    {
        return "Hospital Appointment API is Running!";
    }
}
