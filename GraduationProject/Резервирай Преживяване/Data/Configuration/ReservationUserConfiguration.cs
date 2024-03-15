using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class ReservationUserConfiguration : IEntityTypeConfiguration<ReservationUser>
    {
        public void Configure(EntityTypeBuilder<ReservationUser> builder)
        {
            builder.HasKey(x => new { x.UserId, x.ReservationId });
        }
    }
}
