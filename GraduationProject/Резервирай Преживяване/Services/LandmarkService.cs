using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.LandmarkViewModels;

namespace Резервирай_Преживяване.Services
{
    public class LandmarkService : ILandmarkService
    {
        private readonly ApplicationDbContext context;

        public LandmarkService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<LandmarkViewModel>> GetAllLandmarksAsync()
        {
            return await context.Landmarks.Include(x => x.City).Select(x => new LandmarkViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                CityId = x.CityId,
                CityName = x.City!.Name,
            }).ToListAsync();
        }

        public async Task<LandmarkViewModel> GetLandmarkByIdAsync(Guid Id)
        {
            var landmark = await context.Landmarks.Include(x => x.City).FirstOrDefaultAsync(x => x.Id == Id);
            if (landmark == null)
            {
                throw new ArgumentNullException("Няма такава забележителност");
            }

            var model = new LandmarkViewModel()
            {
                Id = landmark.Id,
                Name = landmark.Name,
                Description = landmark.Description,
                ImageUrl = landmark.ImageUrl,
                CityId = landmark.CityId,
                CityName = landmark.City!.Name,
            };

            return model;
        }

        public async Task<List<LandmarkViewModel>> GetLandmarksByLocation(Guid Id)
        {
            return await context.Landmarks.Include(x => x.City).Where(x => x.CityId == Id).Select(x => new LandmarkViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                CityId = x.CityId,
                CityName = x.City!.Name,
            }).ToListAsync();
        }
    }
}
