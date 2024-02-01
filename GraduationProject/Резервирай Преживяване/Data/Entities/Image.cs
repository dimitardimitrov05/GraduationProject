using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Data.Entities
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Url { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
    }
}
