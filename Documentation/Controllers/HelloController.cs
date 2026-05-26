using Microsoft.AspNetCore.Mvc;

namespace JJDemo.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("hello-name")]
        public string GetHelloName([FromQuery] string name, [FromQuery] string style)
        {
            var hello = style switch
            {
                "default" => "Hello",
                "casual" => "Hi",
                "formal" => "Good day",
                _ => "Hello"
            };

            if (string.IsNullOrWhiteSpace(name))
            {
                return $"{hello}...you";
            }


            return $"{hello} {name}!";
        }

    }
}