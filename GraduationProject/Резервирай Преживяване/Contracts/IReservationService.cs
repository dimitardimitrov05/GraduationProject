using Резервирай_Преживяване.Models.ReservationViewModels;

namespace Резервирай_Преживяване.Contracts
{
    public interface IReservationService
    {
        Task AddReservationAsync(AddReservationViewModel model);
    }
}
