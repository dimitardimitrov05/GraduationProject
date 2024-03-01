using System.Diagnostics.CodeAnalysis;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Models.ResortViewModels
{
    public class IndexResortsViewModel
    {
        public string? FilterCityName { get; set; }
        public string? FilterStarResort { get; set; }
        public string? PricePerNight { get; set; }
        public List<Resort> Resorts { get; set; } = new List<Resort>();
    }
}
