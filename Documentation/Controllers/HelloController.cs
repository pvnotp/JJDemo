using JJ.Enums;
using Microsoft.AspNetCore.Mvc;

namespace JJ.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
       [HttpGet("hello-name")]
        public string GetHelloName([FromQuery] string name, [FromQuery] HelloStyle style)
        {
            var hello = style switch
            {
                HelloStyle.Default => "Hello",
                HelloStyle.Casual => "Hi",
                HelloStyle.Formal => "Good day",
                _ => "Hello"
            };

            return $"{hello} {name}!";
        }

    }

    
}