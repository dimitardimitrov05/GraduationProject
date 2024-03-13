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
        public DbSet<Facility> Facilities { get; set; }

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

            builder.Entity<Resort>()
                .HasMany(x => x.Rooms)
                .WithOne(x => x.Resort)
                .HasForeignKey(x => x.ResortId);

            builder.Entity<Resort>()
                .HasOne(x => x.Facility)
                .WithOne(x => x.Resort)
                .HasForeignKey<Facility>(x => x.ResortId);

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
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Варна",
                    Region = "Варна"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Силистра",
                    Region = "Силистра"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Търговище",
                    Region = "Търговище"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ловеч",
                    Region = "Ловеч"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Кърджали",
                    Region = "Кърджали"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Пловдив",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Добрич",
                    Region = "Добрич"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "София",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Благоевград",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Пазарджик",
                    Region = "Пазарджик"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Перник",
                    Region = "Перник"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Плевен",
                    Region = "Плевен"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Видин",
                    Region = "Видин"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Монтана",
                    Region = "Монтана"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Кюстендил",
                    Region = "2500"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ямбол",
                    Region = "Ямбол"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Русе",
                    Region = "Русе"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Враца",
                    Region = "Враца"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Велико Търново",
                    Region = "Велико Търново"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Шумен",
                    Region = "Шумен"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Габрово",
                    Region = "Габрово"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Разград",
                    Region = "Разград"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Сливен",
                    Region = "Сливен"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Смолян",
                    Region = "Смолян"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Стара Загора",
                    Region = "Стара Загора"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Хасково",
                    Region = "Хасково"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Банско",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Мелник",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Сандански",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Симитли",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Айтос",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ахелой",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Балчик",
                    Region = "Добрич"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Банкя",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Баня",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Белоградчик",
                    Region = "Видин"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Бяла",
                    Region = "Варна"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Велинград",
                    Region = "Пазарджик"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Доспат",
                    Region = "Смолян"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Дряново",
                    Region = "Габрово"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Елхово",
                    Region = "Ямбол"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Казанлък",
                    Region = "Стара Загора"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Калофер",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Карлово",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Китен",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Клисура",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Копривщица",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Лом",
                    Region = "Монтана"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Несебър",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Нова Загора",
                    Region = "Сливен"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Обзор",
                    Region = "Варна"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Павел Баня",
                    Region = "Стара Загора"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Панагюрище",
                    Region = "Пазарджик"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Петрич",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Плиска",
                    Region = "Шумен"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Самоков",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Сапарева баня",
                    Region = "Кюстендил"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Свети влас",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Созопол",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Троян",
                    Region = "Ловеч"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Трявна",
                    Region = "Габрово"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Хисаря",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Боровец",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Пампорово",
                    Region = "Смолян"
                },
                new City()
                {
                    Id = Guid.NewGuid(),
                    Name = "Овощник",
                    Region = "Стара Загора"
                });
        }
    }
}