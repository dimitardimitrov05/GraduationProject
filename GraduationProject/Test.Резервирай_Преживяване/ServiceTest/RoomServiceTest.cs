using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Резервирай_Преживяване.Mock;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.ImageViewModels;
using Резервирай_Преживяване.Models.ResortViewModels;
using Резервирай_Преживяване.Models.RoomViewModels;
using Резервирай_Преживяване.Services;

namespace Test.Резервирай_Преживяване.ServiceTest
{
    [TestFixture]
    public class RoomServiceTest
    {
        [Test]
        public async Task CreateNewRoom_Successfully()
        {
            using var data = DatabaseMock.Instance;
            var roomId = Guid.NewGuid();
            var test = new AddRoomViewModel
            {
                Type = "Test",
                Capacity = "2",
                Description = "Test",
                PricePerNight = 12,
                ResortId = Guid.NewGuid(),
                Images = { new ImageViewModel
                {
                    ImageUrl = "test",
                } },
            };
            data.SaveChanges();

            var roomService = new RoomService(data);

            await roomService.AddAsync(test);

            Assert.That(data.Rooms.Count(), Is.EqualTo(1));
        }

        [Test]
        public void CreateNewRoom_ThrowsNullExceptionsIfModelIsNull()
        {
            using var data = DatabaseMock.Instance;

            var roomService = new RoomService(data);

            var ex = Assert.ThrowsAsync<NullReferenceException>(async ()
               => await roomService.AddAsync(null!));
        }

        [Test]
        public async Task DeleteRoom_RemoveRoomByGivenId()
        {
            using var data = DatabaseMock.Instance;
            var roomId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "1",
                Description = "Test",
                PricePerNight = 12,
                ResortId = Guid.NewGuid(),
                Type = "test"
            });
            data.SaveChanges();

            var roomService = new RoomService(data);

            await roomService.DeleteRoomAsync(roomId);

            Assert.That(data.Rooms.Count(), Is.EqualTo(0));
        }

        [Test]
        public void DeleteRoom_ThrowsNullExceptionIfGivenIdIsWrong()
        {
            using var data = DatabaseMock.Instance;

            var roomService = new RoomService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await roomService.DeleteRoomAsync(Guid.NewGuid()));
        }

        [Test]
        public async Task GetResortId_ReturnsResortIdByGivenRoomId()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            var resortId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "1",
                Description = "Test",
                PricePerNight = 12,
                ResortId = resortId,
                Type = "test"
            });
            data.SaveChanges();

            var roomService = new RoomService(data);

            var result = await roomService.GetResortIdByGivenRoomId(roomId);

            Assert.That(result, Is.EqualTo(resortId));
        }

        [Test]
        public async Task GetResortId_ReturnsNullIfRoomIdIsWrong()
        {
            using var data = DatabaseMock.Instance;

            var roomService = new RoomService(data);

            var result = await roomService.GetResortIdByGivenRoomId(Guid.NewGuid());

            Assert.Null(result);
        }

        [Test]
        public async Task GetResortId_ReturnsNullIfThereIsNoResort()
        {
            using var data = DatabaseMock.Instance;

            var roomService = new RoomService(data);

            var result = await roomService.GetResortIdByGivenRoomId(Guid.NewGuid());

            Assert.Null(result);
        }

        [Test]
        public async Task ListRooms_ReturnsAllRoomByGivenResortId()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = firstResortId,
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = firstCityId,
                City = new City
                {
                    Id = firstCityId,
                    Name = "София",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 23,
                    ResortId = firstResortId
                } }
            });
            data.SaveChanges();

            var roomService = new RoomService(data);

            var result = await roomService.GetAllRoomsByHotelAsync(firstResortId);

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<RoomViewModel>>());
        }

        [Test]
        public async Task ListRooms_ReturnsEmptyListIfThereAreNoRoom()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = firstResortId,
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = firstCityId,
                City = new City
                {
                    Id = firstCityId,
                    Name = "София",
                    Region = "Test"
                },
            });
            data.SaveChanges();

            var roomService = new RoomService(data);

            var result = await roomService.GetAllRoomsByHotelAsync(firstResortId);

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task ListRoom_ReturnsEmptyListIfResortIdIsWrong()
        {
            using var data = DatabaseMock.Instance;

            var roomService = new RoomService(data);

            var result = await roomService.GetAllRoomsByHotelAsync(Guid.NewGuid());

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetRoom_ReturnsRoomToReservateByGivenRoomId()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            var roomId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = firstResortId,
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = firstCityId,
                City = new City
                {
                    Id = firstCityId,
                    Name = "София",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = roomId,
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 23,
                    ResortId = firstResortId
                } }
            });
            data.SaveChanges();

            var roomService = new RoomService(data);

            var result = await roomService.RoomToReservateAsync(roomId);

            Assert.NotNull(result);
            Assert.That(result, Is.TypeOf<RoomViewModel>());
        }

        [Test]
        public void GetRoom_ThrowsNullExceptionsIfRoomIsNull()
        {
            using var data = DatabaseMock.Instance;

            var roomService = new RoomService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await roomService.RoomToReservateAsync(Guid.NewGuid()));
        }

        [Test]
        public async Task GetRoom_ReturnsRoomToEditByGivenRoomId()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "1",
                Description = "Test",
                PricePerNight = 12,
                ResortId = Guid.NewGuid(),
                Type = "test"
            });
            data.SaveChanges();

            var roomService = new RoomService(data);

            var result = await roomService.RoomToEditAsync(roomId);

            Assert.NotNull(result);
            Assert.That(result, Is.TypeOf<RoomViewModel>());
        }

        [Test]
        public void GetRoomToEdit_ThrowsNullExceptionsIfRoomIsNull()
        {
            using var data = DatabaseMock.Instance;

            var roomService = new RoomService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await roomService.RoomToEditAsync(Guid.NewGuid()));
        }

        [Test]
        public void EditRoom_ThrowsNullExceptionsIfRoomIsNull()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "1",
                Description = "Test",
                PricePerNight = 12,
                ResortId = Guid.NewGuid(),
                Type = "test"
            });
            data.SaveChanges();

            var model = new RoomViewModel()
            {
                Id = Guid.NewGuid(),
                Capacity = "2",
                Description = "TestTest",
                PricePerNight = 15,
                Type = "test",
            };

            var roomService = new RoomService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await roomService.EditAsync(model));
        }

        [Test]
        public async Task EditRoom_ReturnsEditedRooomCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var roomId = Guid.NewGuid();
            data.Rooms.Add(new Room
            {
                Id = roomId,
                Capacity = "1",
                Description = "Test",
                PricePerNight = 12,
                ResortId = Guid.NewGuid(),
                Type = "test"
            });
            data.SaveChanges();

            var model = new RoomViewModel()
            {
                Id = roomId,
                Capacity = "2",
                Description = "TestTest",
                PricePerNight = 15,
                Type = "test",
            };

            var roomService = new RoomService(data);

            await roomService.EditAsync(model);

            var result = await data.Rooms
                .Where(x => x.Capacity == model.Capacity)
                .Where(x => x.Description == model.Description)
                .Where(x => x.PricePerNight == model.PricePerNight)
                .Where(x => x.Type == model.Type)
                .FirstOrDefaultAsync();

            Assert.NotNull(result);
        }
    }
}
