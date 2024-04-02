using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Models.RoomViewModels
{
    public class RoomViewModel
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Capacity { get; set; }
        public string? Description { get; set; }
        public decimal? PricePerNight { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
    }
}
