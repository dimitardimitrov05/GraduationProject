using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Services
{
    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext context;

        public RoomService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(AddRoomViewModel model)
        {
            var room = new Room()
            {
                Id = Guid.NewGuid(),
                Type = model.Type,
                Capacity = model.Capacity,
                Description = model.Description,
                PricePerNight = model.PricePerNight,
                Bedrooms = model.Bedrooms,
                Bathrooms = model.Bathrooms,
                ResortId = model.ResortId,
            };

            await context.Rooms.AddAsync(room);
            await context.SaveChangesAsync();
        }

        public async Task<List<Resort>> GetAllResortsAsync()
        {
            return await context.Resorts.ToListAsync();
        }
    }
}
