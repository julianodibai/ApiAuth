using System.Text.Json.Serialization;

namespace ApiAuth.Models
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        [JsonIgnore]
        public string? Role { get; set; }

    }
}
