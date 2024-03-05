using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Models.ImageViewModels
{
    public class ImageViewModel
    {
        [Required]
        public string? ImageUrl { get; set; }
    }
}
