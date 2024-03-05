using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Contracts
{
    public interface IRoomService
    {
        Task AddAsync(AddRoomViewModel model);
        Task<List<Resort>> GetAllResortsAsync();
    }
}
