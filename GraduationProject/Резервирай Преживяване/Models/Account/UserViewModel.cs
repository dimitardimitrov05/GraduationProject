using System.ComponentModel.DataAnnotations;

namespace Резервирай_Преживяване.Models.Account
{
    public class UserViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? PhoneNumber { get; set; }
    }
}