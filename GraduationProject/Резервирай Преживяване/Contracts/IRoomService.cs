using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Contracts
{
    public interface IRoomService
    {
        Task AddAsync(AddRoomViewModel model);
        Task DeleteRoomAsync(Guid id);
        Task<Guid?> GetResortIdByGivenRoomId(Guid id);
        Task<List<RoomViewModel>> GetAllRoomsByHotelAsync(Guid id);
        Task<RoomViewModel> RoomToReservateAsync(Guid id);
        Task<RoomViewModel> RoomToEditAsync(Guid id);
        Task EditAsync(RoomViewModel model);
    }
}
