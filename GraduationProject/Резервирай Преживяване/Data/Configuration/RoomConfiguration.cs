﻿using Microsoft.EntityFrameworkCore;
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

            builder.HasData(CreateRoom());
        }

        private List<Room> CreateRoom()
        {
            var rooms = new List<Room>()
            {
                new Room()
                {
                    Id = Guid.Parse("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d"),
                    Type = "Двойна стая",
                    Capacity = "2",
                    Description = "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. " +
                                  "Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. " +
                                  "Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. " +
                                  "Хигиенни удобства Омния са осигурени във всяка стая.",
                    PricePerNight = 206,
                    ResortId = Guid.Parse("38b0b8f7-271d-4b03-98dc-03e7d6269478"),
                },
                new Room()
                {
                    Id = Guid.Parse("428c043a-5142-4197-bbb7-6ccfa3216ec4"),
                    Type = "Апартамент",
                    Capacity = "4",
                    Description = "Нашият отлично обзаведен Гранд суит осигурява незабравим уют и комфорт. " +
                                  "Тази стая разполага с 2 просторни спални, 2 просторни мраморни бани, състоящи се от душ и вана и голям балкон с маса за хранене и няколко люлки. " +
                                  "Всички наши стаи разполагат със смарт телевизори с многоезични канали и интерактивни услуги за гости. " +
                                  "Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. " +
                                  "Кафе машина Неспресо и хигиенни удобства Омния са осигурени във всяка стая.",
                    PricePerNight = 509,
                    ResortId = Guid.Parse("38b0b8f7-271d-4b03-98dc-03e7d6269478"),
                },

                new Room()
                {
                    Id = Guid.Parse("64934542-3e3c-4292-9275-8370a627564d"),
                    Type = "Двойна делукс стая",
                    Capacity = "2",
                    Description = "Нашите луксозно обзаведени двойни стаи предлагат незабравим уют и комфорт. " +
                                  "Такава стая разполага с просторна мраморна баня и балкон. " +
                                  "Всички наши стаи разполагат със спалня или две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. " +
                                  "Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. " +
                                  "Хигиенни удобства Омния са осигурени във всяка стая.",
                    PricePerNight = 220,
                    ResortId = Guid.Parse("38b0b8f7-271d-4b03-98dc-03e7d6269478"),
                },

                new Room()
                {
                    Id = Guid.Parse("2700d8b7-c588-4435-a761-8c3cb246ea09"),
                    Type = "Студио",
                    Capacity = "2",
                    Description = "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. " +
                                  "Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. " +
                                  "Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. " +
                                  "Хигиенни удобства Омния са осигурени във всяка стая.",
                    PricePerNight = 220,
                    ResortId = Guid.Parse("38b0b8f7-271d-4b03-98dc-03e7d6269478"),
                },

                new Room()
                {
                    Id = Guid.Parse("f085410f-9f1c-445c-a054-9c9e2d5dc538"),
                    Type = "Двойна стая",
                    Capacity = "2",
                    Description = "Тази двойна стая предлага разкош и удобство за двама гости. " +
                                  "Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. " +
                                  "Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. " +
                                  "Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.",
                    PricePerNight = 150,
                    ResortId = Guid.Parse("6016de68-9999-4e82-aee8-ac1f6a9491c3"),
                },
                
                new Room()
                {
                    Id = Guid.Parse("2f4a8de0-5a11-4846-950a-40a566667551"),
                    Type = "Двойна делукс стая",
                    Capacity = "2",
                    Description = "Тази двойна делукс стая е символ на разкош и комфорт, предназначена за двама гости, които ценят изискаността и уютa. " +
                                  "В нея се предлага просторно пространство, разкошно кралско легло, допълнено с висококачествено спално бельо и меки възглавници. " +
                                  "Банята е обичайно обзаведена с изискани детайли и висок клас санитарни удобства, с модерна мраморна облицовка. " +
                                  "Освен това, стаята може да разполага с голям балкон, предлагащ чудесен изглед към околната природа, за да създаде пълноценно усещане за релаксация и лукс.",
                    PricePerNight = 170,
                    ResortId = Guid.Parse("6016de68-9999-4e82-aee8-ac1f6a9491c3"),
                },
                
                new Room()
                {
                    Id = Guid.Parse("d2304ebf-e36c-4ab4-a5cb-4cee96b16594"),
                    Type = "Апартамент",
                    Capacity = "4",
                    Description = "Суитът в хотела представлява върха на лукса и комфорта, като предлага на гостите просторен и стилно обзаведен апартамент. " +
                                  "Този вид стая често включва отделна спалня, просторна дневна зона със собствен бар и елегантен санитарен възел с вана или душ. " +
                                  "Суитът е подходящ за гости, които ценят изисканото удобство и желаят да се насладят на привилегировано пребиваване в хотела.",
                    PricePerNight = 330,
                    ResortId = Guid.Parse("6016de68-9999-4e82-aee8-ac1f6a9491c3"),
                },
                
                new Room()
                {
                    Id = Guid.Parse("5448199b-bbcf-4ea5-a120-417ca95a5933"),
                    Type = "Двойна стая",
                    Capacity = "2",
                    Description = "Тази двойна стая представлява уютно и функционално обзаведено пространство, предназначено за двама гости. " +
                                  "Разполага с едно двойно легло, съчетано с удобства като частна баня и основни удобства за комфортен престой. " +
                                  "Такива стаи предоставят и приятна атмосфера, която позволява на гостите да се почувстват като у дома си, като същевременно се наслаждават на почивката си в нова среда.",
                    PricePerNight = 77,
                    ResortId = Guid.Parse("bca59868-70b8-481e-8e66-88b6e4a32fb6"),
                },
                
                new Room()
                {
                    Id = Guid.Parse("c67902e0-bfc4-4ea9-8112-d99f1a1a1ad7"),
                    Type = "Двойна делукс стая",
                    Capacity = "2",
                    Description = "Двойната делукс стая представлява изискано и уютно пространство, създадено за двама гости, които търсят по-високо ниво на комфорт и удоволствие. " +
                                  "Разполага с изключително удобно двойно легло, обградено от елегантно спално бельо и меки възглавници. " +
                                  "Банята е модерна и стилно обзаведена, с използване на висок клас санитарни удобства. " +
                                  "Освен това, двойната делукс стая предлага и допълнителни удобства като голям балкон и разкошна гледка, за да осигури на гостите незабравимо преживяване в уютна и разкошна обстановка.",
                    PricePerNight = 85,
                    ResortId = Guid.Parse("bca59868-70b8-481e-8e66-88b6e4a32fb6"),
                },
                
                new Room()
                {
                    Id = Guid.Parse("e7a0ce16-bd47-423e-9502-9c3f5354cce7"),
                    Type = "Двойна стая",
                    Capacity = "2",
                    Description = "Тази двойна стая предлага разкош и удобство за двама гости. " +
                                  "Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. " +
                                  "Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. " +
                                  "Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.",
                    PricePerNight = 130,
                    ResortId = Guid.Parse("4e2d6327-b6f3-44b0-a892-242ac5e00d35"),
                },
               
                new Room()
                {
                    Id = Guid.Parse("a8c6414d-3e0d-4163-8ad4-40c5bb9b9fc5"),
                    Type = "Двойна делукс стая",
                    Capacity = "2",
                    Description = "Тази двойна делукс стая е символ на разкош и комфорт, предназначена за двама гости, които ценят изискаността и уютa. " +
                                  "В нея се предлага просторно пространство, разкошно кралско легло, допълнено с висококачествено спално бельо и меки възглавници. " +
                                  "Банята е обичайно обзаведена с изискани детайли и висок клас санитарни удобства, с модерна мраморна облицовка. " +
                                  "Освен това, стаята може да разполага с голям балкон, предлагащ чудесен изглед към околната природа, за да създаде пълноценно усещане за релаксация и лукс.",
                    PricePerNight = 160,
                    ResortId = Guid.Parse("4e2d6327-b6f3-44b0-a892-242ac5e00d35"),
                },
                
                new Room()
                {
                    Id = Guid.Parse("3dc4f47b-086a-417b-a056-43fc084cd25d"),
                    Type = "Двойна стая",
                    Capacity = "2",
                    Description = "Двойните стаи са обзаведени в елегантен артстил, ергономични и хипоалергенни матраци, с богато зареден минибар и телевизор с плосък екран. " +
                                  "Освен това можем да поставим допълнително легло по Ваше желание. " +
                                  "Веднъж когато видите вратата на стаята си, няма да я забравите, защото е с уникална неповторима картина.",
                    PricePerNight = 80,
                    ResortId = Guid.Parse("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"),
                },
                new Room()
                {
                    Id = Guid.Parse("3fd28cb9-1944-4786-8cb3-1bd04a4b4d6c"),
                    Type = "Двойна делукс стая",
                    Capacity = "2",
                    Description = "Art Делукс стаите са обзаведени в елегантен артстил, ергономични и хипоалергенни матраци, с богато зареден минибар и телевизор с плосък екран. " +
                                  "Освен това можем да поставим допълнително легло по Ваше желание. " +
                                  "Веднъж когато видите вратата на стаята си, няма да я забравите, защото е с уникална неповторима картина.",
                    PricePerNight = 100,
                    ResortId = Guid.Parse("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"),
                },
                new Room()
                {
                    Id = Guid.Parse("2c21f5d9-dc4e-4e2c-b4b7-f0a719e96650"),
                    Type = "Апартамент",
                    Capacity = "4",
                    Description = "Арт Джуниор суит се състои от две преходни стаи, луксозна баня и кът за отдих. " +
                                  "Тук ще намерите и кухненски бокс, за да се чувствате наистина като у дома си! " +
                                  "Веднъж когато видите вратата на стаята си, няма да я забравите, защото е с уникална неповторима картина.",
                    PricePerNight = 250,
                    ResortId = Guid.Parse("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"),
                }
            };
            return rooms;
        }
    }
}
