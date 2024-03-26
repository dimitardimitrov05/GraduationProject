using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class FacilityConfiguration : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasData(CreateFacility());
        }

        private List<Facility> CreateFacility()
        {
            var facilities = new List<Facility>()
            {
                new Facility()
                {
                    Id = Guid.Parse("1acd5dac-7a3e-474d-95f4-e94f2a0fe2bb"),
                    Wifi = true,
                    Parking = true,
                    Pool = true,
                    Restaurant = true,
                    Gym = true,
                    SpaCenter = true,
                    RoomService = true,
                    ResortId = Guid.Parse("38b0b8f7-271d-4b03-98dc-03e7d6269478")
                },

                new Facility()
                {
                    Id = Guid.Parse("14efad0c-abb9-4ec1-a003-7b3c0737b2eb"),
                    Wifi = true,
                    Parking = true,
                    Pool = true,
                    Restaurant = true,
                    Gym = true,
                    SpaCenter = true,
                    RoomService = true,
                    ResortId = Guid.Parse("6016de68-9999-4e82-aee8-ac1f6a9491c3")
                },

                new Facility()
                {
                    Id = Guid.Parse("850ca647-84d3-4872-81eb-def5676ddd02"),
                    Wifi = true,
                    Parking = false,
                    Pool = false,
                    Restaurant = false,
                    Gym = false,
                    SpaCenter = false,
                    RoomService = false,
                    ResortId = Guid.Parse("bca59868-70b8-481e-8e66-88b6e4a32fb6")
                },
                new Facility()
                {
                    Id = Guid.Parse("05561c69-9cf4-457d-9e31-1f8013408d1f"),
                    Wifi = true,
                    Parking = false,
                    Pool = true,
                    Restaurant = true,
                    Gym = true,
                    SpaCenter = true,
                    RoomService = true,
                    ResortId = Guid.Parse("4e2d6327-b6f3-44b0-a892-242ac5e00d35")
                },
            };

            return facilities;
        }
    }
}
