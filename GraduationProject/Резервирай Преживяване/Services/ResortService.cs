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

            await context.Resorts.AddAsync(resort);
            await context.SaveChangesAsync();
        }

        public async Task<List<Resort>> FilterResortsAsync(IndexResortsViewModel model)
        {
            var location = model.FilterCityName;
            var stars = model.FilterStarResort;
            var prices = model?.PricePerNight?.Split('-').ToList();
            var resorts = await context.Resorts.Include(x => x.City).Include(x => x.Rooms).ToListAsync();
            if (location != null)
            {
                resorts = resorts.Where(x => x.CityId.ToString() == location).ToList();
            }
            if (stars != null)
            {
                if (stars == "1")
                {
                    resorts = resorts.Where(x => x.Stars == "1").ToList();
                }
                else if (stars == "2")
                {
                    resorts = resorts.Where(x => x.Stars == "2").ToList();
                }
                else if (stars == "3")
                {
                    resorts = resorts.Where(x => x.Stars == "3").ToList();
                }
                else if (stars == "4")
                {
                    resorts = resorts.Where(x => x.Stars == "4").ToList();
                }
                else if (stars == "5")
                {
                    resorts = resorts.Where(x => x.Stars == "5").ToList();
                }
            }
            if (prices != null)
            {
                if (prices?.Count == 1)
                {
                    foreach (var resort in resorts)
                    {
                        var minPricePerNight = resort.Rooms.Min(x => x.PricePerNight);
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
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).Where(x => x.Type == "Къща за гости").ToListAsync();
        }

        public async Task<List<Resort>> GetAllHotelsAsync()
        {
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).Where(x => x.Type == "Хотел").ToListAsync();
        }

        public async Task<List<Resort>> GetAllResortsAsync()
        {
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).ToListAsync();
        }

        public async Task<List<Resort>> GetAllResortsOrderedByStarsAsync()
        {
            return await context.Resorts.Include(x => x.City).Include(x => x.Rooms).OrderByDescending(x => x.Stars).ToListAsync();
        }

        public async Task<ResortViewModel> InfoAsync(Guid id)
        {
            var resort = await context.Resorts.Include(x => x.City).Include(x => x.Rooms).FirstOrDefaultAsync(x => x.Id == id);
            if (resort == null)
            {
                return null;
            }
            var model = new ResortViewModel()
            {
                Name = resort.Name,
                Stars = resort.Stars,
                Type = resort.Type,
                ImageUrl = resort.ImageUrl,
                Description = resort.Description,
                CityName = resort.City?.Name,
                Rooms = resort.Rooms,
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
