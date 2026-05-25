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
                Greeting.GoodMorning => "Good Morning, World!",
                Greeting.GoodNight => "Good Night, World!",
                _ => "Unknown greeting type."
            };
        }

        [HttpGet("echo")]
        public string Echo([FromQuery] string message) => $"Echo: {message}";

    }
}