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

            builder.Entity<Resort>()
                .Property(x => x.Stars).IsRequired(false);

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

            builder.Entity<City>()
                .HasData(new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Бургас",
                    Postcode = "8000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Варна",
                    Postcode = "9000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Силистра",
                    Postcode = "7500"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Търговище",
                    Postcode = "7700"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ловеч",
                    Postcode = "5500"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Кърджали",
                    Postcode = "6600"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Пловдив",
                    Postcode = "4000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Добрич",
                    Postcode = "9300"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "София",
                    Postcode = "1000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Благоевград",
                    Postcode = "2700"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Пазарджик",
                    Postcode = "4400"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Перник",
                    Postcode = "2300"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Плевен",
                    Postcode = "5800"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Видин",
                    Postcode = "3700"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Монтана",
                    Postcode = "3400"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Кюстендил",
                    Postcode = "2500"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ямбол",
                    Postcode = "8600"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Русе",
                    Postcode = "7000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Враца",
                    Postcode = "3000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Велико Търново",
                    Postcode = "5000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Шумен",
                    Postcode = "9700"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Габрово",
                    Postcode = "5300"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Разград",
                    Postcode = "7200"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Сливен",
                    Postcode = "8800"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Смолян",
                    Postcode = "4700"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Стара Загора",
                    Postcode = "6000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Хасково",
                    Postcode = "6300"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Банско",
                    Postcode = "2770"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Мелник",
                    Postcode = "2820"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Сандански",
                    Postcode = "2800"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Симитли",
                    Postcode = "2730"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Айтос",
                    Postcode = "8500"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ахелой",
                    Postcode = "8217"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Балчик",
                    Postcode = "9600"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Банкя",
                    Postcode = "1320"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Баня",
                    Postcode = "4360"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Белоградчик",
                    Postcode = "3900"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Бяла",
                    Postcode = "9101"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Велинград",
                    Postcode = "4600"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Доспат",
                    Postcode = "4831"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Дряново",
                    Postcode = "5370"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Елхово",
                    Postcode = "8700"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Казанлък",
                    Postcode = "6100"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Калофер",
                    Postcode = "4370"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Карлово",
                    Postcode = "4300"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Китен",
                    Postcode = "8183"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Клисура",
                    Postcode = "4341"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Копривщица",
                    Postcode = "2077"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Лом",
                    Postcode = "3600"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Несебър",
                    Postcode = "8230"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Нова Загора",
                    Postcode = "8900"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Обзор",
                    Postcode = "8250"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Павел Баня",
                    Postcode = "6155"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Панагюрище",
                    Postcode = "4500"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Петрич",
                    Postcode = "2850"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Плиска",
                    Postcode = "9920"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Самоков",
                    Postcode = "2000"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Сапарева баня",
                    Postcode = "2650"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Свети власт",
                    Postcode = "8256"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Созопол",
                    Postcode = "8130"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Троян",
                    Postcode = "5600"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Трявна",
                    Postcode = "5350"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Хисаря",
                    Postcode = "4180"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Боровец",
                    Postcode = "2010"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Пампорово",
                    Postcode = "4870"
                });
        }
    }
}