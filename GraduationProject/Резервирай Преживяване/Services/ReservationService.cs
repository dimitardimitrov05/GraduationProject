using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Models.ReservationViewModels;

namespace Резервирай_Преживяване.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext context;

        public ReservationService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddReservationAsync(AddReservationViewModel model)
        {
            var room = await context.Rooms.Where(x => x.Type == model.RoomType).ToListAsync();
            if (room == null)
            {
                throw new ArgumentNullException("Няма налични стаи");
            }

        }
    }
}