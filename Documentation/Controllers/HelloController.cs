using JJ.Enums;
using JJ.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace JJ.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpPost("hello-name")]
        public string GetHelloName([FromBody] GetHelloNameRequest request)
        {
            var hello = request.Style switch
            {
                HelloStyle.Default => "Hello",
                HelloStyle.Casual => "Hi",
                HelloStyle.Formal => "Good day",
                _ => "Hello"
            };

            if (string.IsNullOrEmpty(request.Name))
            {
                return $"{hello}...you";
            }


            return $"{hello} {request.Name}!";
        }
    }
}