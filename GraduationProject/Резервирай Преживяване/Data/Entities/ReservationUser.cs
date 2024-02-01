using Резервирай_Преживяване.Data.Account;

namespace Резервирай_Преживяване.Data.Entities
{
    public class ReservationUser
    {
        public Guid ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
