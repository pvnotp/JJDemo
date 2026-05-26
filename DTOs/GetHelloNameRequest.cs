using JJ.Enums;

namespace JJ.DTOs
{
    public class GetHelloNameRequest
    {
        public string Name { get; set; } = string.Empty;
        public required HelloStyle Style { get; set; }
    }
}