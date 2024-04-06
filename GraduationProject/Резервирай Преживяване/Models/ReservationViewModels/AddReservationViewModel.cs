using System.ComponentModel.DataAnnotations;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Models.ReservationViewModels
{
    public class AddReservationViewModel
    {
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Required]
        public string? Guests { get; set; }
        [Required]
        public string? Total { get; set; }

        public RoomViewModel? Room { get; set; }
        public Guid RoomId { get; set; }
    }
}
