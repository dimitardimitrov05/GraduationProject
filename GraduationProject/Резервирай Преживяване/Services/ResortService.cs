using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models;
using Резервирай_Преживяване.Models.CityViewModels;
using Резервирай_Преживяване.Models.ResortViewModels;

namespace Резервирай_Преживяване.Services
{
    public class ResortService : IResortService
    {
        private readonly ApplicationDbContext context;

        public ResortService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(AddResortViewModel model)
        {
            var resort = new Resort()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Type = model.Type,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                CityId = model.CityId,
                Stars = model.Stars
            };

            var facility = new Facility()
            {
                Id = Guid.NewGuid(),
                Wifi = model.Wifi,
                Parking = model.Parking,
                Pool = model.Pool,
                Restaurant = model.Restaurant,
                Gym = model.Gym,
                SpaCenter = model.SpaCenter,
                RoomService = model.RoomService,
                ResortId = resort.Id,

            };

            await context.Resorts.AddAsync(resort);
            await context.Facilities.AddAsync(facility);
            await context.SaveChangesAsync();
        }

        public async Task<List<ResortViewModel>> FilterResortsAsync(IndexResortsViewModel model)
        {
            var location = model.FilterCityName;
            var stars = model.FilterStarResort;
            var prices = model?.PricePerNight?.Split('-').ToList();
            var orderByOption = model?.OrderByOption;
            var type = model?.FilterType;
            var resorts = await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms).Include(x => x.Facility).
                Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();


            resorts = orderByOption switch
            {
                OrderBy.Stars => resorts.OrderByDescending(x => x.Stars).ToList(),
                _ => resorts
            };
            if (type != null)
            {
                resorts = resorts.Where(x => x.Type == type).ToList();
            }
            if (location != null)
            {
                resorts = resorts.Where(x => x.CityId.ToString() == location).ToList();
            }
            if (stars != null)
            {
                resorts = resorts.Where(x => x.Stars == stars).ToList();
            }
            if (prices != null)
            {
                if (prices?.Count == 1)
                {
                    if (prices[0] == "30")
                    {
                        resorts = resorts.Where(x => x.Rooms.Min(y => y.PricePerNight) <= 30).ToList();
                    }
                    else
                    {
                        resorts = resorts.Where(x => x.Rooms.Min(y => y.PricePerNight) > 100).ToList();
                    }
                }
                else
                {
                    foreach (var resort in resorts)
                    {
                        if (prices?[0] == "30" && prices?[1] == "50")
                        {
                            resorts = resorts.Where(x => x.Rooms.Min(y => y.PricePerNight) > 30 && x.Rooms.Min(y => y.PricePerNight) <= 50).ToList();
                        }
                        else if (prices?[0] == "50" && prices?[1] == "70")
                        {
                            resorts = resorts.Where(x => x.Rooms.Min(y => y.PricePerNight) > 50 && x.Rooms.Min(y => y.PricePerNight) <= 70).ToList();
                        }
                        else if (prices?[0] == "50" && prices?[1] == "70")
                        {
                            resorts = resorts.Where(x => x.Rooms.Min(y => y.PricePerNight) > 50 && x.Rooms.Min(y => y.PricePerNight) <= 70).ToList();
                        }
                        else
                        {
                            resorts = resorts.Where(x => x.Rooms.Min(y => y.PricePerNight) > 70 && x.Rooms.Min(y => y.PricePerNight) <= 100).ToList();
                        }
                    }
                }
            }
            return resorts;
        }

        public Task<List<ResortViewModel>> FilterResortsAsync(IndexResortsViewModel model, string location)
        {
            throw new NotImplementedException();
        }

        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await context.Cities.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<List<ResortViewModel>> GetAllGuesthousesAsync()
        {
            return await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms).Include(x => x.Facility).Where(x => x.Type == "Къща за гости").
                Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();
        }

        public Task<List<ResortViewModel>> GetAllGuesthousesAsync(string location)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResortViewModel>> GetAllHotelsAsync()
        {
            return await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms).Include(x => x.Facility).Where(x => x.Type == "Хотел").
                Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();
        }

        public Task<List<ResortViewModel>> GetAllHotelsAsync(string location)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResortViewModel>> GetAllResortsAsync()
        {
            return await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms).Include(x => x.Facility).
                Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();
        }

        public async Task<List<ResortViewModel>> GetAllResortsOrderedByStarsAsync()
        {
            return await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms).Include(x => x.Facility).OrderByDescending(x => x.Stars).
                Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();
        }

        public async Task<List<ResortViewModel>> GetAllResortsOrderedByStarsAsync(string? location = null)
        {
            var resorts = await context.Resorts
                .Include(x => x.City)
                .ThenInclude(x => x!.Landmarks)
                .Include(x => x.Rooms)
                .Include(x => x.Facility)
                .OrderByDescending(x => x.Stars).
                Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();

            if (location is not null)
            {
                resorts = resorts.Where(x => x.CityName == location).ToList();
            }

            return resorts;
        }

        public async Task<ResortViewModel> InfoAsync(Guid id)
        {
            var resort = await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms).ThenInclude(x => x.Images).Include(x => x.Facility).FirstOrDefaultAsync(x => x.Id == id);
            if (resort == null)
            {
                throw new ArgumentNullException("Няма такъв хотел");
            }
            var model = new ResortViewModel()
            {
                ResortId = resort.Id,
                Name = resort.Name,
                Stars = resort.Stars,
                Type = resort.Type,
                ImageUrl = resort.ImageUrl,
                Description = resort.Description,
                CityName = resort.City?.Name,
                CityRegion = resort.City?.Region,
                CityId = resort.CityId,
                Rooms = resort.Rooms,
                Facility = resort.Facility,
            };

            var landmarks = context.Landmarks.Include(x => x.City).Where(x => x.City!.Name == model.CityRegion).ToHashSet();
            model.Landmarks = landmarks;
            return model;
        }

        public async Task<IndexResortsViewModel> RemoveFiltersAsync()
        {
            var model = new IndexResortsViewModel();
            model.Resorts = await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms).
                Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();
            return model;
        }

        public Task<IndexResortsViewModel> RemoveFiltersAsync(string location)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResortViewModel>> ResortsByLocationAsync(Guid id)
        {
            var resorts = await context.Resorts.Include(x => x.City).ThenInclude(x => x!.Landmarks).Include(x => x.Rooms)
                .Where(x => x.CityId == id)
                .Select(x => new ResortViewModel
                {
                    ResortId = x.Id,
                    Name = x.Name,
                    Stars = x.Stars,
                    Type = x.Type,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    CityName = x.City!.Name,
                    CityId = x.CityId,
                    Rooms = x.Rooms,
                    Landmarks = x.City.Landmarks,
                    Facility = x.Facility,
                }).ToListAsync();

            return resorts;
        }
    }
}
