using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Account
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength (30, MinimumLength = 2)]
        public string? LastName { get; set; }
        public string? Image { get; set; }
        public HashSet<ReservationUser> ReservationUsers { get; set; } = new HashSet<ReservationUser>();
    }
}
