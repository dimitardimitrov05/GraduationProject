using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasMany(x => x.RoomReservations)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);

            builder.HasMany(x => x.Images)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);
        }
    }
}
