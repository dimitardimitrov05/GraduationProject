using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Резервирай_Преживяване.Data.Entities;

namespace Резервирай_Преживяване.Data.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasMany(x => x.Landmarks)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId);

            builder.HasMany(x => x.Resorts)
                .WithOne(x => x.City)
                .HasForeignKey(x => x.CityId);

            builder.HasData(CreateCity());
        }

        private List<City> CreateCity()
        {
            var cities = new List<City>()
            {
                new City()
                {
                    Id = Guid.Parse("9d1d0c7c-daa1-4941-91b4-db28a7da4e03"),
                    Name = "Бургас",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.Parse("5bc79020-4a92-43fb-9c97-7550bdc8f6c9"),
                    Name = "Варна",
                    Region = "Варна"
                },
                new City()
                {
                    Id = Guid.Parse("ff1c955c-57c1-4eaf-b17f-4f44e01fd4a8"),
                    Name = "Силистра",
                    Region = "Силистра"
                },
                new City()
                {
                    Id = Guid.Parse("fa995e10-4149-4267-a7eb-3c3059438071"),
                    Name = "Търговище",
                    Region = "Търговище"
                },
                new City()
                {
                    Id = Guid.Parse("76500059-135a-425f-8aa3-f9b1110cecdf"),
                    Name = "Ловеч",
                    Region = "Ловеч"
                },
                new City()
                {
                    Id = Guid.Parse("48d5bcd4-c99e-4796-8843-852cae764175"),
                    Name = "Кърджали",
                    Region = "Кърджали"
                },
                new City()
                {
                    Id = Guid.Parse("233afddf-48f2-429a-834b-c851f4679d87"),
                    Name = "Пловдив",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.Parse("47181a59-c6c1-42ff-8304-10b56c9f59fe"),
                    Name = "Добрич",
                    Region = "Добрич"
                },
                new City()
                {
                    Id = Guid.Parse("f7e3ef46-c077-48db-9655-dfbb6849b39f"),
                    Name = "София",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.Parse("444c2d73-bb42-4f55-83d3-8930a7257f2e"),
                    Name = "Благоевград",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.Parse("833246ee-f3be-4337-b84a-a0cc58f22558"),
                    Name = "Пазарджик",
                    Region = "Пазарджик"
                },
                new City()
                {
                    Id = Guid.Parse("1e72e4f6-588e-42e6-b93b-9122458547d5"),
                    Name = "Перник",
                    Region = "Перник"
                },
                new City()
                {
                    Id = Guid.Parse("283a59a6-77c5-4b38-a579-05086cd4c375"),
                    Name = "Плевен",
                    Region = "Плевен"
                },
                new City()
                {
                    Id = Guid.Parse("bad041da-8d53-474a-97de-8693510f64ae"),
                    Name = "Видин",
                    Region = "Видин"
                },
                new City()
                {
                    Id = Guid.Parse("78f4e52c-8d18-40e3-b3e4-65049a45f738"),
                    Name = "Монтана",
                    Region = "Монтана"
                },
                new City()
                {
                    Id = Guid.Parse("006902e5-3b36-42da-a288-77a33f44f021"),
                    Name = "Кюстендил",
                    Region = "Кюстендил"
                },
                new City()
                {
                    Id = Guid.Parse("591ae964-8f25-4676-b4bc-713ded8ede5d"),
                    Name = "Ямбол",
                    Region = "Ямбол"
                },
                new City()
                {
                    Id = Guid.Parse("c0729f5e-992e-400d-9b73-7c4c342dd817"),
                    Name = "Русе",
                    Region = "Русе"
                },
                new City()
                {
                    Id = Guid.Parse("ed910cd8-575a-4329-a93c-ef5a14cc956d"),
                    Name = "Враца",
                    Region = "Враца"
                },
                new City()
                {
                    Id = Guid.Parse("3efe9a18-62e8-4ede-b3ef-a411e6136862"),
                    Name = "Велико Търново",
                    Region = "Велико Търново"
                },
                new City()
                {
                    Id = Guid.Parse("a6094c67-3d3b-4f06-9bdf-320df7e8e236"),
                    Name = "Шумен",
                    Region = "Шумен"
                },
                new City()
                {
                    Id = Guid.Parse("48a438e7-5d75-4a51-8076-de210c7f6323"),
                    Name = "Габрово",
                    Region = "Габрово"
                },
                new City()
                {
                    Id = Guid.Parse("d7f43f14-7fd6-4416-bb24-067cc0d4beeb"),
                    Name = "Разград",
                    Region = "Разград"
                },
                new City()
                {
                    Id = Guid.Parse("8ac44425-1406-47e4-b8b1-4349f8417d9e"),
                    Name = "Сливен",
                    Region = "Сливен"
                },
                new City()
                {
                    Id = Guid.Parse("a51a3b6b-59e9-4b38-814f-a90483b12a71"),
                    Name = "Смолян",
                    Region = "Смолян"
                },
                new City()
                {
                    Id = Guid.Parse("e28de390-7ad8-433d-b84b-2229791c65f0"),
                    Name = "Стара Загора",
                    Region = "Стара Загора"
                },
                new City()
                {
                    Id = Guid.Parse("6ba29df6-f14e-4096-a055-352aef819261"),
                    Name = "Хасково",
                    Region = "Хасково"
                },
                new City()
                {
                    Id = Guid.Parse("ad6ceeeb-1a59-415c-8a8e-1eaac8c13956"),
                    Name = "Банско",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.Parse("494eece5-d5df-469f-b878-86eaab056aaf"),
                    Name = "Мелник",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.Parse("237fb6a1-e2f2-4750-aa2c-bbe3e9872d65"),
                    Name = "Сандански",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.Parse("9797d486-63d8-450e-b339-385dca0caa5e"),
                    Name = "Симитли",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.Parse("0241e7d1-b7b8-4fa6-a140-0c1075fab0f6"),
                    Name = "Айтос",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.Parse("666210cb-cca9-4b3d-a583-371dffaa43c3"),
                    Name = "Ахелой",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.Parse("d24f0d58-974b-4d0f-a2e6-008c8fc1e9cf"),
                    Name = "Балчик",
                    Region = "Добрич"
                },
                new City()
                {
                    Id = Guid.Parse("073c2020-0af2-4bee-a3a6-d81c9d479c4b"),
                    Name = "Банкя",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.Parse("dba1ef66-4954-4c89-b67c-68974d455873"),
                    Name = "Баня",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.Parse("db024efc-a028-427f-98c9-a43df3ecf9e8"),
                    Name = "Белоградчик",
                    Region = "Видин"
                },
                new City()
                {
                    Id = Guid.Parse("51dc4e13-81e3-4945-9fce-776d9a76b244"),
                    Name = "Бяла",
                    Region = "Варна"
                },
                new City()
                {
                    Id = Guid.Parse("ee557af5-b2a1-4404-9e82-72c3a699c623"),
                    Name = "Велинград",
                    Region = "Пазарджик"
                },
                new City()
                {
                    Id = Guid.Parse("0448b74c-0a38-45b8-a836-f6e426394fa8"),
                    Name = "Доспат",
                    Region = "Смолян"
                },
                new City()
                {
                    Id = Guid.Parse("1cd1baea-c219-4ba7-bf46-bc154464782b"),
                    Name = "Дряново",
                    Region = "Габрово"
                },
                new City()
                {
                    Id = Guid.Parse("eb34a53b-0d2d-4e5e-9566-72eb48e5d57d"),
                    Name = "Елхово",
                    Region = "Ямбол"
                },
                new City()
                {
                    Id = Guid.Parse("162c6340-19d3-4661-89bb-8b7ccfa669e9"),
                    Name = "Казанлък",
                    Region = "Стара Загора"
                },
                new City()
                {
                    Id = Guid.Parse("d1a3a0d9-336d-4578-9373-3188cb960ebd"),
                    Name = "Калофер",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.Parse("9ab891a5-96ca-446f-8d2f-708b1f3230a8"),
                    Name = "Карлово",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.Parse("a48e9933-b26b-4315-ae4a-99583f912f0f"),
                    Name = "Китен",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.Parse("0b2d14c1-b888-428d-8122-e32623a22537"),
                    Name = "Клисура",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.Parse("5c0a26b7-dd86-4b8f-95e6-93910b86a2c2"),
                    Name = "Копривщица",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.Parse("fae0374e-1581-4790-9a19-44f9323cd9fe"),
                    Name = "Лом",
                    Region = "Монтана"
                },
                new City()
                {
                    Id = Guid.Parse("0b0762c1-37f0-4a14-a2f9-585e50b4c70d"),
                    Name = "Несебър",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.Parse("e0c905d8-4828-48dc-8174-a6f131058c00"),
                    Name = "Нова Загора",
                    Region = "Сливен"
                },
                new City()
                {
                    Id = Guid.Parse("5e54d07a-4bc1-49fa-9196-45f5946f4791"),
                    Name = "Обзор",
                    Region = "Варна"
                },
                new City()
                {
                    Id = Guid.Parse("d36b4336-8391-4da7-b0df-e7a2555d07f6"),
                    Name = "Павел Баня",
                    Region = "Стара Загора"
                },
                new City()
                {
                    Id = Guid.Parse("cfa4fd70-a58b-42cc-abba-bde82ff342d1"),
                    Name = "Панагюрище",
                    Region = "Пазарджик"
                },
                new City()
                {
                    Id = Guid.Parse("9f349c56-8bae-4a9f-ab45-01a26f210fc4"),
                    Name = "Петрич",
                    Region = "Благоевград"
                },
                new City()
                {
                    Id = Guid.Parse("87f7cbb5-e683-4748-9a1a-d8df1b85a3c9"),
                    Name = "Плиска",
                    Region = "Шумен"
                },
                new City()
                {
                    Id = Guid.Parse("7a65d489-304c-4be8-b344-7d53a644e080"),
                    Name = "Самоков",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.Parse("6d207c13-2e2c-454f-9ae6-ce724732a37a"),
                    Name = "Сапарева баня",
                    Region = "Кюстендил"
                },
                new City()
                {
                    Id = Guid.Parse("425cda45-30a8-4574-9394-6e7281e6c19a"),
                    Name = "Свети Влас",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.Parse("ba5cd8db-1c24-4326-9520-419b1b6189b4"),
                    Name = "Созопол",
                    Region = "Бургас"
                },
                new City()
                {
                    Id = Guid.Parse("1e759da7-e6ff-42dc-b35d-428e793cc5ad"),
                    Name = "Троян",
                    Region = "Ловеч"
                },
                new City()
                {
                    Id = Guid.Parse("2567149f-2705-437b-9f2d-12da1b8e20e8"),
                    Name = "Трявна",
                    Region = "Габрово"
                },
                new City()
                {
                    Id = Guid.Parse("730ffb2e-f234-4dff-85f4-c95d4a03c4b7"),
                    Name = "Хисаря",
                    Region = "Пловдив"
                },
                new City()
                {
                    Id = Guid.Parse("aaaf83c1-5b37-4bc9-9260-2ee6725fe657"),
                    Name = "Боровец",
                    Region = "София"
                },
                new City()
                {
                    Id = Guid.Parse("e410ecba-3cd7-4e74-beb1-74047276f450"),
                    Name = "Пампорово",
                    Region = "Смолян"
                },
                new City()
                {
                    Id = Guid.Parse("f612bb1f-975e-434a-920b-5c886ebe3cc6"),
                    Name = "Овощник",
                    Region = "Стара Загора"
                }
            };

            return cities;
        }
    }
}
