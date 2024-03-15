using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Data.Entities
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Required]
        public int? Guests { get; set; }
        [Required]
        public int RoomCount { get; set; }
        public HashSet<RoomReservation> RoomReservations { get; set; } = new HashSet<RoomReservation>();
        public HashSet<ReservationUser> ReservationUsers { get; set; } = new HashSet<ReservationUser>();
    }
}
