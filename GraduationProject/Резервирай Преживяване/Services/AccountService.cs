using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.Account;

namespace Резервирай_Преживяване.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext context;

        public AccountService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task ChangeProfilePicture(string userId, string imageUrl)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id ==  userId);
            user.Image = imageUrl;

            await context.SaveChangesAsync();
        }

        public async Task EditUserAsync(EditUserViewModel model, User user)
        {
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserName = model.Username;
            user.Email = model.Email;
            await context.SaveChangesAsync();
        }

        public async Task<UserViewModel> GetUserReservationsAsync(User user)
        {
            var reservations = await context.Reservations.Include(x => x.ReservationUsers).Include(x => x.RoomReservations).ThenInclude(x => x.Room).ThenInclude(x => x!.Resort).ThenInclude(x => x!.City).ToListAsync();
            var userReservations = new HashSet<Reservation>();
            foreach (var reservation in reservations)
            {
                foreach (var userReservation in reservation.ReservationUsers)
                {
                    if (userReservation.UserId == user.Id)
                    {
                        userReservations.Add(reservation);
                    }
                }
            }
            var model = new UserViewModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.UserName,
                ProfilePicture = user.Image,
                Reservations = userReservations,
            };
            return model;
        }
    }
}
