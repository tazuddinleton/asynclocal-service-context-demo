using System.Text.Json.Serialization.Metadata;
using Microsoft.AspNetCore.Mvc;
using ServiceContextDemo.Services;

namespace ServiceContextDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    private readonly ISingletonService _singletonService;

    public GreetingController(ISingletonService singletonService)
    {
        _singletonService = singletonService;
    }

    [HttpGet]
    public IActionResult Get(string name)
    {
       
        var message = _singletonService.Greet(name);
        return Ok(message);
    }
}