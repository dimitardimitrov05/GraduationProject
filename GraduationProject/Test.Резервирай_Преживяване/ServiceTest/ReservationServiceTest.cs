using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Резервирай_Преживяване.Mock;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.ReservationViewModels;
using Резервирай_Преживяване.Services;

namespace Test.Резервирай_Преживяване.ServiceTest
{
    [TestFixture]
    public class ReservationServiceTest
    {
        [Test]
        public void CreateReservation_ThrowsNullExceptionIfUserIsNull()
        {
            using var data = DatabaseMock.Instance;

            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 5),
                CheckOut = new DateTime(2024, 5, 6),
                Guests = "2",
                Total = "200",
                RoomId = Guid.NewGuid(),
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await reservationService.AddReservationAsync(model, null));
        }

        [Test]
        public void CreateReservation_ThrowsNullExceptionIfModelIsNull()
        {
            using var data = DatabaseMock.Instance;

            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await reservationService.AddReservationAsync(null, user));
        }

        [Test]
        public void CreateReservation_ThrowsArgumentExceptionIfCheckInIsInvalid()
        {
            using var data = DatabaseMock.Instance;

            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2023, 5, 5),
                CheckOut = new DateTime(2024, 5, 6),
                Guests = "2",
                Total = "200",
                RoomId = Guid.NewGuid(),
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentException>(async ()
               => await reservationService.AddReservationAsync(model, user));
        }

        [Test]
        public void CreateReservation_ThrowsArgumentExceptionIfCheckOutIsInvalid()
        {
            using var data = DatabaseMock.Instance;

            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 5),
                CheckOut = new DateTime(2023, 5, 6),
                Guests = "2",
                Total = "200",
                RoomId = Guid.NewGuid(),
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentException>(async ()
               => await reservationService.AddReservationAsync(model, user));
        }

        [Test]
        public void CreateReservariton_ThrowsArgumentExceptionIfCheckInDateIsBetterThanCheckOutDate()
        {
            using var data = DatabaseMock.Instance;

            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 5),
                CheckOut = new DateTime(2024, 5, 4),
                Guests = "2",
                Total = "200",
                RoomId = Guid.NewGuid(),
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentException>(async ()
               => await reservationService.AddReservationAsync(model, user));
        }

        [Test]
        public void CreateReservation_ThrowsNullExceptionIfRoomIsNotExistent()
        {
            using var data = DatabaseMock.Instance;

            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 5),
                CheckOut = new DateTime(2024, 5, 6),
                Guests = "2",
                Total = "200",
                RoomId = Guid.NewGuid(),
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await reservationService.AddReservationAsync(model, user));
        }

        [Test]
        public void CreateReservation_ThrowsArgumentExeptionIfGuestsAreBetterThanRoomCapacity()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "2",
                Description = "test",
                PricePerNight = 23,
                Type = "test",
                ResortId = Guid.NewGuid(),
            });
            data.SaveChanges();
            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 5),
                CheckOut = new DateTime(2024, 5, 6),
                Guests = "3",
                Total = "200",
                RoomId = roomId,
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentException>(async ()
               => await reservationService.AddReservationAsync(model, user));
        }

        [Test]
        public async Task CreateReservation_CreateReservationCorrectlyIfThereAreNoOtherReservation()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "2",
                Description = "test",
                PricePerNight = 23,
                Type = "test",
                ResortId = Guid.NewGuid(),
            });
            data.SaveChanges();
            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 5),
                CheckOut = new DateTime(2024, 5, 6),
                Guests = "2",
                Total = "23.0",
                RoomId = roomId,
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            await reservationService.AddReservationAsync(model, user);

            Assert.That(data.Reservations.Count, Is.EqualTo(1));
        }

        [Test]
        public void CreateReservation_ThrowsArgumentExceptionIfTheDateIsSameAsAlreadyBookedReservation()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            var reservationId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "2",
                Description = "test",
                PricePerNight = 23,
                Type = "test",
                ResortId = Guid.NewGuid(),
                RoomReservations =
                {
                    new RoomReservation
                    {
                        RoomId = roomId,
                        ReservationId = reservationId,
                        Reservation = new Reservation()
                        {
                            Id = reservationId,
                             CheckIn = new DateTime(2024, 5, 5),
                             CheckOut = new DateTime(2024, 5, 6),
                             Guests = 2,
                             Total = 23,
                        }
                    }
                }
            });
            data.SaveChanges();
            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 5),
                CheckOut = new DateTime(2024, 5, 6),
                Guests = "2",
                Total = "23.0",
                RoomId = roomId,
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            var ex = Assert.ThrowsAsync<ArgumentException>(async ()
               => await reservationService.AddReservationAsync(model, user));
        }

        [Test]
        public async Task CreateReservation_CreateReservationCorrectlyWhenThereAreMoreReservationForTheRoom()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            var reservationId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "2",
                Description = "test",
                PricePerNight = 23,
                Type = "test",
                ResortId = Guid.NewGuid(),
                RoomReservations =
                {
                    new RoomReservation
                    {
                        RoomId = roomId,
                        ReservationId = reservationId,
                        Reservation = new Reservation()
                        {
                            Id = reservationId,
                             CheckIn = new DateTime(2024, 5, 5),
                             CheckOut = new DateTime(2024, 5, 6),
                             Guests = 2,
                             Total = 23,
                        }
                    }
                }
            });
            data.SaveChanges();
            var model = new AddReservationViewModel()
            {
                CheckIn = new DateTime(2024, 5, 8),
                CheckOut = new DateTime(2024, 5, 9),
                Guests = "2",
                Total = "23.0",
                RoomId = roomId,
            };
            var user = new User()
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                UserName = "test",
            };

            var reservationService = new ReservationService(data);

            await reservationService.AddReservationAsync(model, user);

            Assert.That(data.Reservations.Count, Is.EqualTo(2));
        }
    }
}
