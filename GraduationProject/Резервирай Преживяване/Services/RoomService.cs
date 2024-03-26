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
                ResortId = model.ResortId,
            };

            await context.Rooms.AddAsync(room);

            foreach (var item in model.Images)
            {
                var image = new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = item.ImageUrl,
                    RoomId = room.Id,
                };

                room.Images.Add(image);
            }

            await context.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(Guid id)
        {
            var room = await context.Rooms.FirstOrDefaultAsync(x => x.Id == id);
            context.Rooms.Remove(room!);
            await context.SaveChangesAsync();
        }

        public async Task<Guid?> GetResortIdByGivenRoomId(Guid id)
        {
            return await context.Rooms.Where(x => x.Id == id).Select(x => x.ResortId).FirstOrDefaultAsync(); ;
        }
    }
}
