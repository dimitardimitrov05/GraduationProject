using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
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
            if (user == null)
            {
                throw new ArgumentNullException("Невалиден потребител");
            }
            if (model == null)
            {
                throw new ArgumentNullException("Попълни данните");
            }
            if (model.CheckIn < DateTime.Now || model.CheckIn > model.CheckOut || model.CheckOut < DateTime.Now)
            {
                throw new ArgumentException("Невалидна дата");
            }

            var room = await context.Rooms.Include(x => x.RoomReservations).ThenInclude(x => x.Reservation).ThenInclude(x => x!.ReservationUsers).FirstOrDefaultAsync(x => x.Id == model.RoomId);
            if (room == null)
            {
                throw new ArgumentNullException("Няма такава стая");
            }
            if (int.Parse(model.Guests!) > int.Parse(room.Capacity!))
            {
                throw new ArgumentException("Капацитетът на стаята е по-малък от въведените гости");
            }

            var totalAsString = model.Total!.Replace('.', ',');
            var total = Convert.ToDecimal(totalAsString);

            if (room.RoomReservations.Count == 0)
            {
                var newReservation = new Reservation()
                {
                    Id = Guid.NewGuid(),
                    CheckIn = model.CheckIn,
                    CheckOut = model.CheckOut,
                    Guests = int.Parse(model.Guests!),
                    Total = total,
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
            }
            else
            {
                foreach (var reservation in room.RoomReservations)
                {
                    if ((reservation.Reservation!.CheckIn >= model.CheckIn && reservation.Reservation!.CheckOut >= model.CheckIn) 
                        || (reservation.Reservation!.CheckIn >= model.CheckOut && reservation.Reservation!.CheckOut >= model.CheckOut))
                    {
                        throw new ArgumentException("Стаята не е налична");
                    }
                    var newReservation = new Reservation()
                    {
                        Id = Guid.NewGuid(),
                        CheckIn = model.CheckIn,
                        CheckOut = model.CheckOut,
                        Guests = int.Parse(model.Guests!),
                        Total = total,
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

            await context.SaveChangesAsync();
        }
    }
}