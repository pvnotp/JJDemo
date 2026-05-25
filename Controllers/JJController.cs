using JJDemo.Enums;
using Microsoft.AspNetCore.Mvc;

namespace JJDemo.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class JJController : ControllerBase
    {
        [HttpGet("greeting")]
        public string GetGreeting([FromQuery] Greeting greetingType)
        {
            return greetingType switch
            {
                Greeting.Hello => "Hello World!",
                Greeting.Goodbye => "Goodbye World!",
                _ => "Unknown greeting type."
            };
        }
    }
}