using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Data.Configuration;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<Landmark> Landmarks { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new ResortConfiguration());
            builder.ApplyConfiguration(new LandmarkConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());
            builder.ApplyConfiguration(new RoomReservationConfiguration());
            builder.ApplyConfiguration(new ReservationConfiguration());
            builder.ApplyConfiguration(new ReservationUserConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new FacilityConfiguration());
            builder.ApplyConfiguration(new ImageConfiguration());

            base.OnModelCreating(builder);
        }
    }
}