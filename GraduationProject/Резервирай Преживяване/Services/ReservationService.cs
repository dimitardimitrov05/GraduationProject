using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.ReservationViewModels;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext context;

        public ReservationService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddReservationAsync(AddReservationViewModel model, User user)
        {
            if (model.CheckIn < DateTime.Now || model.CheckIn > model.CheckOut || model.CheckOut < DateTime.Now)
            {
                throw new ArgumentException("Невалидна дата");
            }

           /* var rooms = await context.Rooms.Include(x => x.RoomReservations).ThenInclude(x => x.Reservation).Where(x => x.Type == model.RoomType).ToListAsync();
            if (rooms == null)
            {
                throw new ArgumentNullException("Няма налични стаи");
            }
            foreach (var room in rooms)
            {
                if (room.RoomReservations == null)
                {
                    var newReservation = new Reservation()
                    {
                        Id = Guid.NewGuid(),
                        CheckIn = model.CheckIn,
                        CheckOut = model.CheckOut,
                        Guests = model.Guests,
                        Total = model.Total,
                    };

                    var roomReservation = new RoomReservation()
                    {
                        RoomId = room.Id,
                        Room = room,
                        ReservationId = newReservation.Id,
                        Reservation = newReservation,
                    };
                    room.RoomReservations!.Add(roomReservation);

                    var reservationUser = new ReservationUser()
                    {
                        ReservationId = newReservation.Id,
                        Reservation = newReservation,
                        UserId = user.Id,
                        User = user
                    };
                    user.ReservationUsers.Add(reservationUser);

                    context.Reservations.Add(newReservation);
                    break;
                }
            }
           */
            await context.SaveChangesAsync();
        }
    }
}