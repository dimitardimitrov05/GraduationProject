using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Entities;
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

        public async Task<List<Resort>> FilterResortsAsync(IndexResortsViewModel model)
        {
            var location = model.FilterCityName;
            var stars = model.FilterStarResort;
            var prices = model?.PricePerNight?.Split('-').ToList();
            var resorts = await context.Resorts.Include(x => x.City).Include(x => x.Rooms).Include(x => x.Facility).ToListAsync();
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
                    foreach (var resort in resorts)
                    {
                        var minPricePerNight = resort.Rooms.OrderBy(x => x.PricePerNight).Select(x => x.PricePerNight).FirstOrDefault();
                        if (prices[0] == "30")
                        {
                            resorts = resorts.Where(x => minPricePerNight <= 30).ToList();
                        }
                        else
                        {
                            resorts = resorts.Where(x => minPricePerNight > 100).ToList();
                        }
                    }
                }
                else
                {
                    foreach (var resort in resorts)
                    {
                        var minPricePerNight = resort.Rooms.Min(x => x.PricePerNight);
                        if (prices?[0] == "30" && prices?[1] == "50")
                        {
                            resorts = resorts.Where(x => minPricePerNight > 30 && minPricePerNight <= 50).ToList();
                        }
                        else if (prices?[0] == "50" && prices?[1] == "70")
                        {
                            resorts = resorts.Where(x => minPricePerNight > 50 && minPricePerNight <= 70).ToList();
                        }
                        else if (prices?[0] == "50" && prices?[1] == "70")
                        {
                            resorts = resorts.Where(x => minPricePerNight > 50 && minPricePerNight <= 70).ToList();
                        }
                        else
                        {
                            resorts = resorts.Where(x => minPricePerNight > 70 && minPricePerNight <= 100).ToList();
                        }
                    }
                }
            }
            return resorts;
        }

        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await context.Cities.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<List<Resort>> GetAllGuesthousesAsync()
        {
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).Include(x => x.Facility).Where(x => x.Type == "Къща за гости").ToListAsync();
        }

        public async Task<List<Resort>> GetAllHotelsAsync()
        {
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).Include(x => x.Facility).Where(x => x.Type == "Хотел").ToListAsync();
        }

        public async Task<List<Resort>> GetAllResortsAsync()
        {
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).Include(x => x.Facility).ToListAsync();
        }

        public async Task<List<Resort>> GetAllResortsOrderedByStarsAsync()
        {
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).Include(x => x.Facility).OrderByDescending(x => x.Stars).ToListAsync();
        }

        public async Task<ResortViewModel> InfoAsync(Guid id)
        {
            var resort = await context.Resorts.Include(x => x.City).Include(x => x.Rooms).ThenInclude(x => x.Images).Include(x => x.Facility).FirstOrDefaultAsync(x => x.Id == id);
            if (resort == null)
            {
                return null;
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
                Rooms = resort.Rooms,
                Facility = resort.Facility,
            };
            return model;
        }

        public async Task<IndexResortsViewModel> RemoveFiltersAsync()
        {
            var model = new IndexResortsViewModel();
            model.Resorts = await context.Resorts.Include(x => x.City).Include(x => x.Rooms).ToListAsync();
            return model;
        }
    }
}
