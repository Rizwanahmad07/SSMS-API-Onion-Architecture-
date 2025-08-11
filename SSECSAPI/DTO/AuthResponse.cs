using SSECSAPI.Models;

namespace SSECSAPI.DTO
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
        public string StatusCode { get; set; }
    }

}
