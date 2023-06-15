using Microsoft.AspNetCore.Mvc;

namespace temp.Controllers;

[ApiController]
[Route("test")]
public class Test : ControllerBase
{
   
    [HttpGet]
    public string Get()
    {
        return "Server is running...";
    }
}
