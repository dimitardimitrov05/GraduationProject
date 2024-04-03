using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.LandmarkViewModels;

namespace Резервирай_Преживяване.Contracts
{
    public interface ILandmarkService
    {
        Task<List<LandmarkViewModel>> GetAllLandmarksAsync();
        Task<LandmarkViewModel> GetLandmarkByIdAsync(Guid Id);
        Task<List<LandmarkViewModel>> GetLandmarksByLocation(Guid Id);
    }
}
