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
            var rooms = await context.Rooms.Include(x => x.RoomReservations).ThenInclude(x => x.Reservation).Where(x => x.Type == model.RoomType).ToListAsync();
            if (rooms == null)
            {
                throw new ArgumentNullException("Няма налични стаи");
            }
            if (model.CheckIn < DateTime.Now || model.CheckIn > model.CheckOut || model.CheckOut < DateTime.Now)
            {
                throw new ArgumentException("Невалидна дата");
            }

        }
    }
}