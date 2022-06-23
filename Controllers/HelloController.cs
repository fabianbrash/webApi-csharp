namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities;

[ApiController]
//[Route("[controller]")]
public class HelloController : ControllerBase
{

    [HttpGet("/hello")]
    public IActionResult SayHello()
    {
        var hello = "Hello World C#!!";
        return Ok(hello);
    }
}