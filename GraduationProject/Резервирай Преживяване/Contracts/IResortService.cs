using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.CityViewModels;
using Резервирай_Преживяване.Models.ResortViewModels;

namespace Резервирай_Преживяване.Contracts
{
    public interface IResortService
    {
        Task AddAsync(AddResortViewModel model);
        Task<List<ResortViewModel>> GetAllResortsAsync();
        Task<List<City>> GetAllCitiesAsync();
        Task<List<ResortViewModel>> GetAllResortsOrderedByStarsAsync();
        Task<List<ResortViewModel>> GetAllHotelsAsync();
        Task<List<ResortViewModel>> GetAllGuesthousesAsync();

        Task<List<ResortViewModel>> FilterResortsAsync(IndexResortsViewModel model);
        Task<IndexResortsViewModel> RemoveFiltersAsync();
        Task<ResortViewModel> InfoAsync(Guid id);
    }
}
