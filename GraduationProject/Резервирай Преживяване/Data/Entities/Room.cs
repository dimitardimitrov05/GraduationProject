using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace Резервирай_Преживяване.Data.Entities
{
    public class Room
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Capacity { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public decimal? PricePerNight { get; set; }
        public bool? IsTaken { get; set; }
        [Required]
        public Guid? ResortId { get; set; }
        public Resort? Resort { get; set; }
        public HashSet<RoomReservation> RoomReservations { get; set; } = new HashSet<RoomReservation>();
        public HashSet<Image> Images { get; set; } = new HashSet<Image>();
    }
}
