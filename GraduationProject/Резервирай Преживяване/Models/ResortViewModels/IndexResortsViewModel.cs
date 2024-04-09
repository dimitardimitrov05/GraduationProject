using System.Diagnostics.CodeAnalysis;
using Резервирай_Преживяване.Data.Entities;
using Резервирай_Преживяване.Models.ReservationViewModels;

namespace Резервирай_Преживяване.Models.ResortViewModels
{
    public class IndexResortsViewModel
    {
        public string? FilterCityName { get; set; }
        public string? FilterStarResort { get; set; }
        public string? PricePerNight { get; set; }
        public string? FilterType { get; set; }
        public OrderBy OrderByOption { get; set; }
        public DateTime? FilterCheckIn { get; set; }
        public DateTime? FilterCheckOut { get; set; }
        public List<ResortViewModel> Resorts { get; set; } = new List<ResortViewModel>();
    }
}
