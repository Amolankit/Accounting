using Accounting.Domain.Domain;

namespace Accounting.Domain;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
        
    // Navigation Properties
    public ICollection<UserRole> UserRoles { get; set; }
}