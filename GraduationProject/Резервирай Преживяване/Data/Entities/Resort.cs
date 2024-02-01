using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Data.Entities
{
    public class Resort
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public Guid CityId { get; set; }
        public City City { get; set; }
        public HashSet<Room> Rooms { get; set; } = new HashSet<Room>();
    }
}
