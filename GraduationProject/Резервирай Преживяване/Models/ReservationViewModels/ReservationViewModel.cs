using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Models.ReservationViewModels
{
    public class ReservationViewModel
    {
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        [Required]
        public string? Location { get; set; }
        public int? Guests { get; set; }
    }
}
