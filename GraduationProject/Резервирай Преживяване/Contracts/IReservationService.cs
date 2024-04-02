using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Models.ReservationViewModels;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Contracts
{
    public interface IReservationService
    {
        Task AddReservationAsync(AddReservationViewModel model, User user);
    }
}
