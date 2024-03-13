using System.ComponentModel.DataAnnotations;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Models.ResortViewModels
{
    public class ResortViewModel
    {
        public Guid ResortId { get; set; }
        public string? Name { get; set; }
        [StringLength(1)]
        public string? Stars { get; set; }
        public string? Type { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public string? CityName { get; set; }
        public HashSet<Room> Rooms { get; set; } = new HashSet<Room>();
        public Facility? Facility { get; set; }
    }
}
