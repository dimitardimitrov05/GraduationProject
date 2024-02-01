using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Data.Account;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<City>()
                .HasMany(x => x.Landmarks)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId);

            builder.Entity<City>()
                .HasMany(x => x.Resorts)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId);

            builder.Entity<City>()
                .HasIndex(x => x.Postcode)
                .IsUnique();

            builder.Entity<Resort>()
                .HasMany(x => x.Rooms)
                .WithOne(x => x.Resort)
                .HasForeignKey(x => x.ResortId);

            builder.Entity<RoomReservation>()
                .HasKey(x => new { x.ReservationId, x.RoomId });

            builder.Entity<Reservation>()
                .HasMany(x => x.RoomReservations)
                .WithOne(x => x.Reservation)
                .HasForeignKey(x => x.ReservationId);

            builder.Entity<Room>()
                .HasMany(x => x.RoomReservations)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);

            builder.Entity<ReservationUser>()
                .HasKey(x => new { x.UserId, x.ReservationId });

            builder.Entity<User>()
                .HasMany(x => x.ReservationUsers)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.Entity<Reservation>()
                .HasMany(x => x.ReservationUsers)
                .WithOne(x => x.Reservation)
                .HasForeignKey(x => x.ReservationId);

            builder.Entity<Room>()
                .HasMany(x => x.Images)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);
        }
    }
}