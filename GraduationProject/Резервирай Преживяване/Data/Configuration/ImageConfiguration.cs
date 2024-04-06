using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(CreateImage());
        }

        private List<Image> CreateImage()
        {
            var images = new List<Image>()
            {
                new Image()
                {
                    Id = Guid.Parse("61b4df33-b86b-4b73-b212-c5d57c48e6a5"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/07/g-standard-room-1.jpg",
                    RoomId = Guid.Parse("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d")
                },
                new Image()
                {
                    Id = Guid.Parse("b1723baa-22bc-48a3-8f01-3a982ce2937f"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/07/g-standard-room-5.jpg",
                    RoomId = Guid.Parse("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d")
                },
                new Image()
                {
                    Id = Guid.Parse("c989374d-b63e-4644-b4a1-62442bfee31b"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/07/g-standard-room-3.jpg",
                    RoomId = Guid.Parse("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d")
                },
                new Image()
                {
                    Id = Guid.Parse("3c3bf7e9-fe86-4f7f-b901-cd757a5ce106"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/10/g-grand-suite-1.jpg",
                    RoomId = Guid.Parse("428c043a-5142-4197-bbb7-6ccfa3216ec4")
                },
                new Image()
                {
                    Id = Guid.Parse("3753e392-e28d-45ce-a14e-cd4b4747e60f"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/10/g-grand-suite-4.jpg",
                    RoomId = Guid.Parse("428c043a-5142-4197-bbb7-6ccfa3216ec4")
                },
                new Image()
                {
                    Id = Guid.Parse("b73fa054-2ba6-4fcd-9e2b-11970fdd14c5"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/10/g-grand-suite-7.jpg",
                    RoomId = Guid.Parse("428c043a-5142-4197-bbb7-6ccfa3216ec4")
                },
                new Image()
                {
                    Id = Guid.Parse("7f4dd05e-defa-425a-b397-50f516ba0918"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/07/g-deluxe-room-3.jpg",
                    RoomId = Guid.Parse("64934542-3e3c-4292-9275-8370a627564d")
                },
                new Image()
                {
                    Id = Guid.Parse("7fda1cee-e088-42bd-a96d-7bb2668ff1ac"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/07/g-deluxe-room-3.jpg",
                    RoomId = Guid.Parse("64934542-3e3c-4292-9275-8370a627564d")
                },
                new Image()
                {
                    Id = Guid.Parse("ae3b5a32-2b82-4564-9f66-0d42d37dcf3f"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/07/g-studio-1.jpg",
                    RoomId = Guid.Parse("2700d8b7-c588-4435-a761-8c3cb246ea09")
                },
                new Image()
                {
                    Id = Guid.Parse("16b9815c-312b-425f-9457-5e0aac9b9b9f"),
                    Url = "https://knyazpavel.com/wp-content/uploads/2022/07/g-studio-3.jpg",
                    RoomId = Guid.Parse("2700d8b7-c588-4435-a761-8c3cb246ea09")
                },
                new Image()
                {
                    Id = Guid.Parse("f952762b-02db-46b2-8a16-749a4b02c8e3"),
                    Url = "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-superior-1.jpg",
                    RoomId = Guid.Parse("f085410f-9f1c-445c-a054-9c9e2d5dc538")
                },
                new Image()
                {
                    Id = Guid.Parse("287ec125-d9ac-4812-875c-c25a1edbd26a"),
                    Url = "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-deluxe-1.jpg",
                    RoomId = Guid.Parse("2f4a8de0-5a11-4846-950a-40a566667551")
                },
                new Image()
                {
                    Id = Guid.Parse("5ecb5d89-3bad-499c-8829-122373b78d1a"),
                    Url = "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-junior.jpg",
                    RoomId = Guid.Parse("d2304ebf-e36c-4ab4-a5cb-4cee96b16594")
                },
                new Image()
                {
                    Id = Guid.Parse("a681b116-c215-4afa-8bb9-5ada9aca8e14"),
                    Url = "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-onebed-1.jpg",
                    RoomId = Guid.Parse("d2304ebf-e36c-4ab4-a5cb-4cee96b16594")
                },
                new Image()
                {
                    Id = Guid.Parse("c7bfddd7-21e4-4889-a965-50658b2fc0b0"),
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/269595082.jpg?k=c578ea8f75b5a3ffb94c0ca4d63c9a6c409917a8c667f25d5581998b14ee933e&o=&hp=1",
                    RoomId = Guid.Parse("180592ca-bea7-4053-bb15-1071c22e0bee")
                },
                new Image()
                {
                    Id = Guid.Parse("c7e3e256-36ae-41df-8877-08177211dae6"),
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/28526865.jpg?k=4b44f7b37a762ea94fd57532745360d8fa60bfe8dce69638e0a9055cd57ea082&o=&hp=1",
                    RoomId = Guid.Parse("180592ca-bea7-4053-bb15-1071c22e0bee")
                },
                new Image()
                {
                    Id = Guid.Parse("bfb98bd3-500b-4ae1-bdac-d8969fa72431"),
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/79141090.jpg?k=8e2d3d5efc66fdf3d4be0a201bfbc5875498dc3f8b50cf9dfedbdedd6c8212ff&o=&hp=1",
                    RoomId = Guid.Parse("c67902e0-bfc4-4ea9-8112-d99f1a1a1ad7")
                },
                new Image()
                {
                    Id = Guid.Parse("757260dd-8734-4561-81c7-d084463e75b6"),
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/28526876.jpg?k=f67a479c6e2a572518f27f18d4b02c3dccd6ef52dfd2deca33decf3a3513b832&o=&hp=1",
                    RoomId = Guid.Parse("c67902e0-bfc4-4ea9-8112-d99f1a1a1ad7")
                },
                new Image()
                {
                    Id = Guid.Parse("2e5b99e7-f348-44e1-bc48-5a0c931609cd"),
                    Url = "https://secure.exely.com/resource/images/rt/115277/637208410773519493-30162600-3c56-4778-a706-4f3d0df5df13",
                    RoomId = Guid.Parse("e7a0ce16-bd47-423e-9502-9c3f5354cce7")
                },
                new Image()
                {
                    Id = Guid.Parse("79414ac2-e348-470b-ad6f-ff70f4ef82e7"),
                    Url = "https://secure.exely.com/resource/images/rt/115277/637199615130730753-478d48e1-0f24-4453-98e0-2b7426f43ae6",
                    RoomId = Guid.Parse("e7a0ce16-bd47-423e-9502-9c3f5354cce7")
                },
                new Image()
                {
                    Id = Guid.Parse("41f6bdb1-7924-445c-a613-2f8633adbf37"),
                    Url = "https://secure.exely.com/resource/images/rt/115278/637199615874092347-ac4a8004-136b-474b-a422-6dbb36c5e5bd",
                    RoomId = Guid.Parse("a8c6414d-3e0d-4163-8ad4-40c5bb9b9fc5")
                },
                new Image()
                {
                    Id = Guid.Parse("e08ac724-5e07-4339-a187-5289e888e519"),
                    Url = "https://secure.exely.com/resource/images/rt/115278/637199615874775089-69f03cf9-1bc4-4cae-9037-91a7a4e64d03",
                    RoomId = Guid.Parse("a8c6414d-3e0d-4163-8ad4-40c5bb9b9fc5")
                },
                new Image()
                {
                    Id = Guid.Parse("593703e4-7390-4ac5-bf7c-403b57ee9ff3"),
                    Url = "https://art.magusexperience.com/wp-content/uploads/2020/03/plabo.net-0395.jpg",
                    RoomId = Guid.Parse("3dc4f47b-086a-417b-a056-43fc084cd25d")
                },
                new Image()
                {
                    Id = Guid.Parse("46f00b54-6702-46d9-b847-b07e4c330fcf"),
                    Url = "https://art.magusexperience.com/wp-content/uploads/2020/03/21.jpg",
                    RoomId = Guid.Parse("3dc4f47b-086a-417b-a056-43fc084cd25d")
                },
                new Image()
                {
                    Id = Guid.Parse("32688fbb-ba73-495a-9acd-81a2848fe603"),
                    Url = "https://art.magusexperience.com/wp-content/uploads/2020/03/23.jpg",
                    RoomId = Guid.Parse("3dc4f47b-086a-417b-a056-43fc084cd25d")
                },
                new Image()
                {
                    Id = Guid.Parse("80653e22-de9c-4484-8063-8cb8939a35ba"),
                    Url = "https://art.magusexperience.com/wp-content/uploads/2020/03/17.jpg",
                    RoomId = Guid.Parse("3fd28cb9-1944-4786-8cb3-1bd04a4b4d6c")
                },
                new Image()
                {
                    Id = Guid.Parse("b1ac92c9-210a-4918-b1b7-24ec84ac6f04"),
                    Url = "https://art.magusexperience.com/wp-content/uploads/2020/03/19.jpg",
                    RoomId = Guid.Parse("3fd28cb9-1944-4786-8cb3-1bd04a4b4d6c")
                },
                new Image()
                {
                    Id = Guid.Parse("feaadf70-eaba-4177-9e80-b1ec52c4247d"),
                    Url = "https://art.magusexperience.com/wp-content/uploads/2020/03/plabo.net-0616.jpg",
                    RoomId = Guid.Parse("2c21f5d9-dc4e-4e2c-b4b7-f0a719e96650")
                },
                new Image()
                {
                    Id = Guid.Parse("b5e5fcdd-0436-4b6e-9886-dc05766892d7"),
                    Url = "https://art.magusexperience.com/wp-content/uploads/2020/03/plabo.net-0616.jpg",
                    RoomId = Guid.Parse("2c21f5d9-dc4e-4e2c-b4b7-f0a719e96650")
                },
                new Image()
                {
                    Id = Guid.Parse("5636c8c3-d55a-4bfc-8427-6423e387259b"),
                    Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/269595129.jpg?k=4510139b9a0b9d3cdd42fed45f0a6f932d2fe620ceee14014e69d2bab241a084&o=&hp=1",
                    RoomId = Guid.Parse("5448199b-bbcf-4ea5-a120-417ca95a5933")
                },
            };
            return images;
        }
    }
}
