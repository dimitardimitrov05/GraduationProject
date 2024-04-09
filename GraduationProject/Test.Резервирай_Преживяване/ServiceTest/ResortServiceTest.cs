using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Резервирай_Преживяване.Mock;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.CityViewModels;
using Резервирай_Преживяване.Models.ResortViewModels;
using Резервирай_Преживяване.Services;

namespace Test.Резервирай_Преживяване.ServiceTest
{
    [TestFixture]
    internal class ResortServiceTest
    {
        [Test]
        public async Task CreateNewResort_Successfully()
        {
            using var data = DatabaseMock.Instance;
            var test = new AddResortViewModel
            {
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = Guid.NewGuid(),
            };

            data.SaveChanges();

            var resortService = new ResortService(data);

            await resortService.AddAsync(test);

            Assert.That(data.Resorts.Count(), Is.EqualTo(1));
        }

        [Test]
        public void CreateNewResort_ThrowsNullExceptionsIfModelIsNull()
        {
            using var data = DatabaseMock.Instance;

            var resortService = new ResortService(data);

            var ex = Assert.ThrowsAsync<NullReferenceException>(async ()
               => await resortService.AddAsync(null!));
        }

        [Test]
        public async Task ListCities_ReturnsAllCities()
        {
            using var data = DatabaseMock.Instance;
            data.Cities.Add(new City
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Region = "Test"
            });
            data.Cities.Add(new City
            {
                Id = Guid.NewGuid(),
                Name = "Test1",
                Region = "Test1"
            });
            data.SaveChanges();

            var resortService = new ResortService(data);

            var result = await resortService.GetAllCitiesAsync();

            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Is.TypeOf<List<City>>());
        }

        [Test]
        public async Task ListResorts_ReturnsAllResorts()
        {
            using var data = DatabaseMock.Instance;
            var cityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Test",
                    Region = "Test"
                }
            });
            data.SaveChanges();

            var resortService = new ResortService(data);

            var result = await resortService.GetAllResortsAsync();

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task GetResort_ReturnsResortByIdCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var resortId = Guid.NewGuid();
            var cityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = resortId,
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Test",
                    Region = "Test"
                }
            });
            data.SaveChanges();

            var resortService = new ResortService(data);

            var result = await resortService.InfoAsync(resortId);

            Assert.IsNotNull(result);
            Assert.That(result, Is.TypeOf<ResortViewModel>());
        }

        [Test]
        public void GetResort_ThrowsNullExceptionsIfResortIdIsNull()
        {
            using var data = DatabaseMock.Instance;

            var resortService = new ResortService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await resortService.InfoAsync(Guid.NewGuid()));
        }

        [Test]
        public async Task ListResorts_RemoveFiltersSuccessfullt()
        {
            using var data = DatabaseMock.Instance;
            var cityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Test",
                    Region = "Test"
                }
            });
            data.SaveChanges();

            var resortService = new ResortService(data);

            var result = await resortService.RemoveFiltersAsync();

            Assert.That(result.Resorts.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<IndexResortsViewModel>());
        }

        [Test]
        public async Task ListResorts_GetAllResortsByCityGivenId()
        {
            using var data = DatabaseMock.Instance;
            var cityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Test",
                    Region = "Test"
                }
            });
            data.SaveChanges();

            var resortService = new ResortService(data);

            var result = await resortService.ResortsByLocationAsync(cityId);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_ReturnsEmptyListIfGivenWrongResortId()
        {
            using var data = DatabaseMock.Instance;

            var resortService = new ResortService(data);

            var result = await resortService.ResortsByLocationAsync(Guid.NewGuid());

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task ListResorts_FilterResortsByGivenLocationName()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
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
                }
            });
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "5",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                FilterCityName = "София",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }
    }
}
