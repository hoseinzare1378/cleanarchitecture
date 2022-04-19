using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities.System
{
    public class User: IdentityUser<int>
    {
        public virtual ICollection<UserRole>? UserRoles { get; set; }
    }
}