using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello CI/CD!";
    }
    
    // ДОБАВЬ ЭТОТ МЕТОД:
    [HttpGet("add/{a}/{b}")]
    public int Add(int a, int b)
    {
        return a + b;
    }
}