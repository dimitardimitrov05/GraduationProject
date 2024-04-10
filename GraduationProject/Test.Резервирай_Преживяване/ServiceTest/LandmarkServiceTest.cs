using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Резервирай_Преживяване.Mock;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.LandmarkViewModels;
using Резервирай_Преживяване.Models.ResortViewModels;
using Резервирай_Преживяване.Services;

namespace Test.Резервирай_Преживяване.ServiceTest
{
    [TestFixture]
    public class LandmarkServiceTest
    {
        [Test]
        public async Task ListLandmarks_ReturnsAllLandmarksCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var cityId = Guid.NewGuid();
            data.Landmarks.Add(new Landmark
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Description = "Test",
                ImageUrl = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Test", 
                    Region = "Test",
                }
            });
            data.SaveChanges();

            var landmarkService = new LandmarkService(data);

            var result = await landmarkService.GetAllLandmarksAsync();

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<LandmarkViewModel>>());
        }

        [Test]
        public async Task ListLandmarks_ReturnsNullIfThrereIsNoLandmarks()
        {
            using var data = DatabaseMock.Instance;

            var landmarkService = new LandmarkService(data);

            var result = await landmarkService.GetAllLandmarksAsync();

            Assert.That(result.Count, Is.EqualTo(0));   
        }

        [Test]
        public async Task GetLandmark_ReturnsLandmarkByIdCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var landmarkId = Guid.NewGuid();
            var cityId = Guid.NewGuid();
            data.Landmarks.Add(new Landmark
            {
                Id = landmarkId,
                Name = "Test",
                Description = "Test",
                ImageUrl = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Test",
                    Region = "Test",
                }
            });
            data.SaveChanges();

            var landmarkService = new LandmarkService(data);

            var result = await landmarkService.GetLandmarkByIdAsync(landmarkId);

            Assert.IsNotNull(result);
            Assert.That(result, Is.TypeOf<LandmarkViewModel>());
        }

        [Test]
        public void GetLandmark_ThrowsNullExceptionIfGivenWrongLandmarkId()
        {
            var data = DatabaseMock.Instance;

            var landmarkService = new LandmarkService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await landmarkService.GetLandmarkByIdAsync(Guid.NewGuid()));
        }

        [Test]
        public async Task GetLandmark_ReturnsLandmarkByGivenLocationId()
        {
            var data = DatabaseMock.Instance;
            var cityId = Guid.NewGuid();
            data.Landmarks.Add(new Landmark
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Description = "Test",
                ImageUrl = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Test",
                    Region = "Test",
                }
            });
            data.SaveChanges();

            var landmarkService = new LandmarkService(data);

            var result = await landmarkService.GetLandmarksByLocation(cityId);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<LandmarkViewModel>>());
        }

        [Test]
        public async Task GetLandmark_ThrowsNullExceptionIfGivenWrongLocationId()
        {
            var data = DatabaseMock.Instance;

            var landmarkService = new LandmarkService(data);

            var result = await landmarkService.GetLandmarksByLocation(Guid.NewGuid());

            Assert.That(result.Count(), Is.EqualTo(0));
        }
    }
}
