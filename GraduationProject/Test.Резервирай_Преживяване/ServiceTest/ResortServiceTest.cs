using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Резервирай_Преживяване.Mock;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models;
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
        public async Task ListResorts_FilterResortsByGivenLocationId()
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
                FilterCityName = firstCityId.ToString(),
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByGivenStars()
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
                Stars = "4",
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
                FilterStarResort = "5",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByGivenPricePerNightForRoomUnder30()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            var secondResortId = Guid.NewGuid();
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
            data.Resorts.Add(new Resort
            {
                Id = secondResortId,
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 123,
                    ResortId = secondResortId
                } }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                PricePerNight = "30",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByGivenPricePerNightForRoomOver100()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            var secondResortId = Guid.NewGuid();
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
            data.Resorts.Add(new Resort
            {
                Id = secondResortId,
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 123,
                    ResortId = secondResortId
                } }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                PricePerNight = "100",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByGivenPricePerNightForRoomBetween30And50()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            var secondResortId = Guid.NewGuid();
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
                    PricePerNight = 43,
                    ResortId = firstResortId
                } }
            });
            data.Resorts.Add(new Resort
            {
                Id = secondResortId,
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 123,
                    ResortId = secondResortId
                } }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                PricePerNight = "30-50",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByGivenPricePerNightForRoomBetween50And70()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            var secondResortId = Guid.NewGuid();
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
                    PricePerNight = 63,
                    ResortId = firstResortId
                } }
            });
            data.Resorts.Add(new Resort
            {
                Id = secondResortId,
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 123,
                    ResortId = secondResortId
                } }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                PricePerNight = "50-70",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByGivenPricePerNightForRoomBetween70And100()
        {
            using var data = DatabaseMock.Instance;

            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            var firstResortId = Guid.NewGuid();
            var secondResortId = Guid.NewGuid();
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
                    PricePerNight = 83,
                    ResortId = firstResortId
                } }
            });
            data.Resorts.Add(new Resort
            {
                Id = secondResortId,
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 123,
                    ResortId = secondResortId
                } }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                PricePerNight = "70-100",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByTypeWhichIsHotel()
        {
            using var data = DatabaseMock.Instance;
            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "5",
                Type = "Kъща за гости",
                ImageUrl = "Test",
                Description = "Test",
                CityId = firstCityId,
                City = new City
                {
                    Id = firstCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
            });
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                FilterType = "Хотел",
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_OrderResortsByStars()
        {
            using var data = DatabaseMock.Instance;
            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "5",
                Type = "Kъща за гости",
                ImageUrl = "Test",
                Description = "Test",
                CityId = firstCityId,
                City = new City
                {
                    Id = firstCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
            });
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                OrderByOption = OrderBy.Stars
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result, Is.Ordered.Descending.By("Stars"));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public async Task ListResorts_FilterResortsByRoomsByAvailability()
        {
            using var data = DatabaseMock.Instance;
            var cityId = Guid.NewGuid();
            var resortId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = resortId,
                Name = "Test",
                Stars = "5",
                Type = "Kъща за гости",
                ImageUrl = "Test",
                Description = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 123,
                    ResortId = resortId
                } }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                FilterCheckIn = new DateTime(2024, 5, 13),
                FilterCheckOut = new DateTime(2024, 5, 14),
            };

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(filter);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }

        [Test]
        public void ListResorts_ThrowsArgumentExceptionsIfCheckInAndCheckOutFilterIsInvalid()
        {
            using var data = DatabaseMock.Instance;
            var cityId = Guid.NewGuid();
            var resortId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = resortId,
                Name = "Test",
                Stars = "5",
                Type = "Kъща за гости",
                ImageUrl = "Test",
                Description = "Test",
                CityId = cityId,
                City = new City
                {
                    Id = cityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
                Rooms = {new Room
                {
                    Id = Guid.NewGuid(),
                    Capacity = "2",
                    Description = "Test",
                    Type = "Test",
                    PricePerNight = 123,
                    ResortId = resortId
                } }
            });
            data.SaveChanges();

            var filter = new IndexResortsViewModel()
            {
                FilterCheckIn = new DateTime(2023, 5, 13),
                FilterCheckOut = new DateTime(2023, 5, 14),
            };

            var resortService = new ResortService(data);

            var ex = Assert.ThrowsAsync<ArgumentException>(async ()
               => await resortService.FilterResortsAsync(filter));

            Assert.That(ex.Message, Is.EqualTo("Невалидна дата"));
        }

        [Test]
        public async Task ListResorts_ReturnsAllResortsIfThereNoFilters()
        {
            using var data = DatabaseMock.Instance;
            var firstCityId = Guid.NewGuid();
            var secondCityId = Guid.NewGuid();
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "5",
                Type = "Kъща за гости",
                ImageUrl = "Test",
                Description = "Test",
                CityId = firstCityId,
                City = new City
                {
                    Id = firstCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
            });
            data.Resorts.Add(new Resort
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Stars = "4",
                Type = "Хотел",
                ImageUrl = "Test",
                Description = "Test",
                CityId = secondCityId,
                City = new City
                {
                    Id = secondCityId,
                    Name = "Пловдив",
                    Region = "Test"
                },
            });
            data.SaveChanges();

            var resortService = new ResortService(data);

            var result = await resortService.FilterResortsAsync(new IndexResortsViewModel());

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result, Is.TypeOf<List<ResortViewModel>>());
        }
    }
}
