using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Models.LandmarkViewModels
{
    public class LandmarkViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid CityId { get; set; }
        public string? CityName { get; set; }
    }
}
