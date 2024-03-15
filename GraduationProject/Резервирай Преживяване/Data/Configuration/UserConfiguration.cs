using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Account;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(x => x.ReservationUsers)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.HasData(CreateUser());
        }

        private List<User> CreateUser()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                FirstName = "Георги",
                LastName = "Иванов",
                UserName = "George",
                NormalizedUserName = "GEORGE",
                Email = "george@abv.bg",
                NormalizedEmail = "GEORGE@ABV.BG",
            };
            user.PasswordHash =
                hasher.HashPassword(user, "Georgi1!");

            users.Add(user);

            var admin = new User()
            {
                Id = "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                FirstName = "Димитър",
                LastName = "Димитров",
                UserName = "MeetYou",
                NormalizedUserName = "MEETYOU",
                Email = "dimitar@abv.bg",
                NormalizedEmail = "DIMITAR@ABV.BG",
            };
            admin.PasswordHash =
                hasher.HashPassword(admin, "Dimitar1!");

            users.Add(admin);

            return users;
        }
    }
}
