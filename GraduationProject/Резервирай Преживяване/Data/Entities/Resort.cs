using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Резервирай_Преживяване.Data.Entities
{
    public class Resort
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [StringLength(1)]
        [Required]
        public string? Stars { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public Guid CityId { get; set; }
        public City? City { get; set; }
        public Facility? Facility { get; set; }
        public HashSet<Room> Rooms { get; set; } = new HashSet<Room>();
    }
}
