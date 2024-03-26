using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Models.ReservationViewModels
{
    public class AddReservationViewModel
    {
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Required]
        public int? Guests { get; set; }
        [Required]
        public int? RoomCount { get; set; }
        [Required]
        public decimal? Total { get; set; }
        [Required]
        public string? RoomType { get; set; }
    }
}
