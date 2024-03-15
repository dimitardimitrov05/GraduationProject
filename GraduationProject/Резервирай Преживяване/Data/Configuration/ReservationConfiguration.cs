using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasMany(x => x.RoomReservations)
                .WithOne(x => x.Reservation)
                .HasForeignKey(x => x.ReservationId);

            builder.HasMany(x => x.ReservationUsers)
                .WithOne(x => x.Reservation)
                .HasForeignKey(x => x.ReservationId);
        }
    }
}
