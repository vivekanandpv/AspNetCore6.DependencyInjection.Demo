using AspNetCore6.DependencyInjection.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore6.DependencyInjection.Demo.Controllers;

[Route("api/v1/sample")]
[ApiController]
public class SampleController : ControllerBase
{
    private readonly Person _person;
    private readonly Car _car;

    public SampleController(Person person, Car car)
    {
        Console.WriteLine("SampleController created");
        _person = person;
        _car = car;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}