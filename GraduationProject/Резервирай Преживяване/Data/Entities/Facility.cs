using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Data.Entities
{
    public class Facility
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public bool? Wifi { get; set; }
        [Required]
        public bool? Parking { get; set; }
        [Required]
        public bool? Pool { get; set; }
        [Required]
        public bool? Restaurant { get; set; }
        [Required]
        public bool? Gym { get; set; }
        [Required]
        public bool? SpaCenter { get; set; }
        [Required]
        public bool? RoomService { get; set; }
        [Required]
        public Guid ResortId { get; set; }
        public Resort? Resort { get; set; }
    }
}
