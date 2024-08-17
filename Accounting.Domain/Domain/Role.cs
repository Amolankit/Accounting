using Accounting.Domain.Domain;

namespace Accounting.Domain;

public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
        
    // Navigation Properties
    public ICollection<UserRole> UserRoles { get; set; }
}