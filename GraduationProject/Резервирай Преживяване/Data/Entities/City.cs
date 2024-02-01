using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Резервирай_Преживяване.Data.Entities
{
    public class City
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string? Name { get; set; }
        [Required]
        public string? Postcode { get; set; }
        public HashSet<Resort> Resorts { get; set; } = new HashSet<Resort>();
        public HashSet<Landmark> Landmarks { get; set; } = new HashSet<Landmark>();
    }
}
