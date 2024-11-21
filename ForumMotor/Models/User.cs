using Microsoft.AspNetCore.Identity;

namespace ForumMotor.Models
{
    public class User : IdentityUser
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
