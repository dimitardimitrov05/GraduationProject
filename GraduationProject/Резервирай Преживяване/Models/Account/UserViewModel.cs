using System.ComponentModel.DataAnnotations;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Models.Account
{
    public class UserViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? ProfilePicture { get; set; }
        public IFormFile? Picture { get; set; }
        public HashSet<Reservation> Reservations { get; set; } = new HashSet<Reservation>();
    }
}