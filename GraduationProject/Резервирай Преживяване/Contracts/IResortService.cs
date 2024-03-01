using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.CityViewModels;
using Резервирай_Преживяване.Models.ResortViewModels;

namespace Резервирай_Преживяване.Contracts
{
    public interface IResortService
    {
        Task AddAsync(AddResortViewModel model);
        Task<List<Resort>> GetAllResortsAsync();
        Task<List<City>> GetAllCitiesAsync();
        Task<List<Resort>> GetAllResortsOrderedByStarsAsync();
        Task<List<Resort>> GetAllHotelsAsync();
        Task<List<Resort>> GetAllGuesthousesAsync();

        Task<List<Resort>> FilterResortsAsync(IndexResortsViewModel model);
        Task<IndexResortsViewModel> RemoveFiltersAsync();
        Task<ResortViewModel> InfoAsync(Guid id);
    }
}
