using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class RoomReservationConfiguration : IEntityTypeConfiguration<RoomReservation>
    {
        public void Configure(EntityTypeBuilder<RoomReservation> builder)
        {
            builder.HasKey(x => new { x.ReservationId, x.RoomId });
        }
    }
}
