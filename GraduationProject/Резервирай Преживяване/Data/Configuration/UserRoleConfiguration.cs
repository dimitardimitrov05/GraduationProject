using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(CreateUserRole());
        }

        private HashSet<IdentityUserRole<string>> CreateUserRole()
        {
            return new HashSet<IdentityUserRole<string>>
            {
                new()
                {
                    UserId = "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                    RoleId = "5dd65fa9-eb2c-4372-8084-8c501347e74f"
                },
                new()
                {
                    UserId = "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                    RoleId = "528726ea-e421-4a80-b303-f035355599de"
                },
            };
        }
    }
}
