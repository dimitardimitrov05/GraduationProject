using System.ComponentModel.DataAnnotations;
using Резервирай_Преживяване.Models.ImageViewModels;
namespace Резервирай_Преживяване.Models.RoomViewModels
{
    public class AddRoomViewModel
    {
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Capacity { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public decimal? PricePerNight { get; set; }
        [Required]
        public int? Bedrooms { get; set; }
        [Required]
        public int? Bathrooms { get; set; }
        [Required]
        public Guid? ResortId { get; set; }
        public List<ImageViewModel> Images { get; set; } = new List<ImageViewModel>();
    }
}
