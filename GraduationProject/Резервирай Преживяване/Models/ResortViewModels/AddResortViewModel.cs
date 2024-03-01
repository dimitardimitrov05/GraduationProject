using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Models.ResortViewModels
{
    public class AddResortViewModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Stars { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public Guid CityId { get; set; }
    }
}
