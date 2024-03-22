using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Models.Account;

namespace Резервирай_Преживяване.Contracts
{
    public interface IAccountService
    {
        Task<UserViewModel> GetUserReservationsAsync(User user);
        Task EditUserAsync(EditUserViewModel model, User user);
    }
}
