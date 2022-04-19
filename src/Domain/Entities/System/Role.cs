using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities.System
{
    public class Role: IdentityRole<int>
    {
        public virtual ICollection<UserRole>? UserRoles { get; set; }
        public Role(string name)
        {
            this.Name = name;
        }
    }
}