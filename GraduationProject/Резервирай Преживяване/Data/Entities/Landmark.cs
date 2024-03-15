using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Data.Entities
{
    public class Landmark
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public Guid CityId { get; set; }
        public City? City { get; set; }
    }
}
