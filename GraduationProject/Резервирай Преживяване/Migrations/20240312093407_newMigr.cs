using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class newMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cities_Postcode",
                table: "Cities");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("089cee59-8d4f-423e-9a78-73ea848c2f15"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("09c77998-25f4-4f4f-855e-f215f31b5880"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("18ff4ca1-bf93-41c7-b4d4-2137afbc92ee"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2421f970-218f-479b-978d-9e88366b8e9b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("29edff2f-b90c-416d-bc1d-76d59f0e4dd9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2a7db128-7c90-42c1-b84e-fe83fdc5b31d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2ae578f3-8491-4b7c-8160-114fa15905df"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2bfb43fc-b0b6-44f2-93a6-c6ae5882c24b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("315f22f8-40a3-48b2-be93-0d3482485e49"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("33b7d571-24d6-4236-ab48-21dd2425d343"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3461f601-8778-46ea-9582-fdac3b66df9c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3d878ab3-b630-4a58-b847-8e002040a6c5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("43f72542-bcea-4b32-9182-d8997f842665"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("490fa1ba-5897-4c62-956b-c86ff971ab5a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4ae83a65-17a4-4577-94d8-44c6e702c624"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b658dec-69f0-4782-a8ff-d3a552e65f94"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4c60e3ab-5e3e-45a0-8c2b-38b4056f8573"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4cb51ded-e6d0-42b3-98c6-676d8de4f475"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4ef1dcf6-cdd6-4cae-bb33-42c5a6f734ef"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("51e415ee-5fcf-4172-a0dd-d66c6294cbbd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("532f2c58-0b50-4dd0-afce-43ea8f68495a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5564d472-57ac-47eb-89ae-1974b01ab19a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("55d782e4-c03e-4d0a-90ce-9a462fa4f41a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5b9bc29e-dd91-41bc-90ae-6310136a2b6f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c94c9f1-cc6a-428b-99f1-0369510d463e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("66d3467f-b3f1-4e77-9573-2dda8e3d606a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6941b9a2-39dd-4f83-8d8c-144cb0feb393"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("733981c7-bb24-4894-bae1-2d4dd2913322"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("734b45fe-a31e-4f85-8f46-0156095609d9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("73fb50f7-4e06-4e00-a6b2-32869dc36f11"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("75be5e66-52a5-4f1a-9839-a74d2fece0ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("77e0e509-1c7f-4aeb-b8c1-76ac458c5a59"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7a4aabc4-f512-4322-b05b-4f3b0e0f131b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7ba3675f-fc9b-4859-9e7a-729860906ef6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("80675a56-4212-425f-bc2c-4986871549ae"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("82afabe5-80a5-42e4-a515-771ad102ceb8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8be05989-3cbf-4105-a6dd-8a81c9f83276"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8ed045fe-7095-4edf-912b-1348cc019c1f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("91aa7910-1422-488f-90c5-6e305a96f4f2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("943fe0a0-bb03-471c-9529-68417c68f1e8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a68ff87-04c0-4dac-a39c-e8759f5d127a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9af0f7b7-d3d9-4beb-beda-bfc99ef9ff43"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0a45b4c-c1b8-4e94-a8de-181c4bdfb2f8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0ff2b6a-b818-4730-852c-a1fae4f7e3ca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a4ebdb24-9aeb-41d9-a91d-bd1199eacd9e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a8da022b-c68a-4131-b96f-837f45de04a7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("abfca343-73c5-4bc4-bc1e-902afe12c6e1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("af650f80-c8ba-4c2a-9c3d-10e7f4f00d03"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("af6ef6c7-ade0-4181-8ab2-c62eb668e542"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b05bc648-73cc-4b18-91ba-4a435f7f3080"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b2d8b92d-7fa1-41f3-b403-76c8d4ffd140"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ba1d4e11-c8c0-4ed5-884a-98e07b8b476b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c18d9fe5-222c-48b4-91fa-e6d73e781e18"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cb78b846-a0c3-43f3-ac39-ecc25c92bafe"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d55f6e7e-f851-446e-9916-69c578d4c8ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d6416941-a431-4dd1-b07a-fd6e49bfa396"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("daf095b3-fadb-4d04-a6a4-5bc30d16ca6b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dbdc4b23-e7dc-4487-9f71-6b6411710f54"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e13c2d1a-b03a-4dd3-bed9-d3160194d871"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e33adc42-c19e-4cef-8795-32601062f06d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eb5a75bf-6652-47ee-8d63-3f8236bbaaca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("efca9570-a0a5-4e02-aafc-3d118b0be0ac"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f2ae187d-bc51-48fc-85e0-ea4955dc3a56"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f61f0c9f-9955-44cb-aa52-08b49e1d38e9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f7ca3216-839b-4b38-95a7-f8c682cce095"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fdf7c7e9-7bfd-4e25-b273-a66793db40f4"));

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Cities");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { new Guid("044f8d23-5412-48ee-9fe6-668c324ae009"), "Благоевград", "Благоевград" },
                    { new Guid("08413d50-d3e3-45c7-aa06-d1359e6f304e"), "Русе", "Русе" },
                    { new Guid("0c54d9b6-96a3-404c-a8a0-9287147e1fe1"), "Лом", "Монтана" },
                    { new Guid("0d34715f-adda-40b8-91f5-6e23c7af51a8"), "Велико Търново", "Велико Търново" },
                    { new Guid("0efcd63f-9c19-4c59-9f4a-aa7f176074cd"), "Балчик", "Добрич" },
                    { new Guid("14310b9e-7430-4cff-a15c-72f06595992c"), "Силистра", "Силистра" },
                    { new Guid("167d8ef2-8de9-42e1-af96-59fc782c1d35"), "Панагюрище", "Пазарджик" },
                    { new Guid("20a8a494-03ae-40c0-9474-c6bff742ff1e"), "Казанлък", "Стара Загора" },
                    { new Guid("24bd9ff0-a4d8-481e-94a9-b481d1c1fbe5"), "Бяла", "Варна" },
                    { new Guid("288f9b1f-bab8-4803-872c-6944e1dca17f"), "Трявна", "Габрово" },
                    { new Guid("2d7a97e5-a08e-4ea5-9630-e1c42976bd51"), "Кюстендил", "2500" },
                    { new Guid("2fcb9fae-5f5c-4536-b182-abfd609158e2"), "Симитли", "Благоевград" },
                    { new Guid("30cd2ee4-310f-4a25-986b-6f7d465c2a39"), "Несебър", "Бургас" },
                    { new Guid("326211c7-1f7b-485a-ba88-8e376f5330e0"), "Търговище", "Търговище" },
                    { new Guid("3c80c35f-610e-49f4-a473-4b00091b56a6"), "Айтос", "Бургас" },
                    { new Guid("3d7476bb-b3da-4413-b76d-fa85ebad46ea"), "Враца", "Враца" },
                    { new Guid("43320305-fd87-416f-af2f-0877e53c6382"), "Варна", "Варна" },
                    { new Guid("44b9e06e-e3e6-46db-93e5-afe18afe1213"), "Бургас", "Бургас" },
                    { new Guid("49af785e-2bdb-470e-a04a-c7509ea11990"), "Ямбол", "Ямбол" },
                    { new Guid("4d73d550-90f6-4418-bca5-565be40a1999"), "Смолян", "Смолян" },
                    { new Guid("5416b2f3-a698-44d5-a550-d712c08c2749"), "София", "София" },
                    { new Guid("59b474c1-16e9-4e39-9c57-75a7633127a6"), "Кърджали", "Кърджали" },
                    { new Guid("5ada3746-891b-4134-b935-5e5d88cb7c11"), "Разград", "Разград" },
                    { new Guid("5fc35891-eed5-4509-8365-0ce420bca8d4"), "Шумен", "Шумен" },
                    { new Guid("72ac0665-548e-411c-a4a3-2c821a88dd6c"), "Доспат", "Смолян" },
                    { new Guid("7305a68d-615a-467d-a919-55ba6070d762"), "Плиска", "Шумен" },
                    { new Guid("77c85120-5951-47e4-b743-3173d4093560"), "Свети влас", "Бургас" },
                    { new Guid("797a1392-bad9-4438-84ad-00e62a2038a1"), "Видин", "Видин" },
                    { new Guid("7bf3a252-0562-4d55-a310-bd9ab4bca530"), "Боровец", "София" },
                    { new Guid("85c602c4-cfc8-43ae-8fdc-a0fc837eb3ce"), "Ловеч", "Ловеч" },
                    { new Guid("88e9bb91-0881-4166-9c7f-9f519941375b"), "Нова Загора", "Сливен" },
                    { new Guid("8ba23070-6733-40a8-b57d-e503f1d171a2"), "Пловдив", "Пловдив" },
                    { new Guid("8bca9a4a-0d4c-4bca-97c5-eba270260c3e"), "Плевен", "Плевен" },
                    { new Guid("9405b409-3790-411e-8988-029e13068487"), "Стара Загора", "Стара Загора" },
                    { new Guid("96b45633-c16d-43d1-b81b-d5d449ba7d7c"), "Пампорово", "Смолян" },
                    { new Guid("9e17acee-abc1-41b6-a80f-93e982607675"), "Обзор", "Варна" },
                    { new Guid("9fde9dd5-0b16-4a15-b1a4-0b2f9c6274a7"), "Сливен", "Сливен" },
                    { new Guid("a0bf7221-b30e-4236-b287-de4e94f445f1"), "Троян", "Ловеч" },
                    { new Guid("a1900cc4-cf37-4bc1-8a30-0ed2c2a26731"), "Банкя", "София" },
                    { new Guid("a80a0edc-3a48-430d-bb90-f11565535d16"), "Велинград", "Пазарджик" },
                    { new Guid("aeb6d0bc-a0fd-4ae1-9643-27c4a7060953"), "Баня", "Пловдив" },
                    { new Guid("aecd9893-6691-405f-9109-7cdb9cea5791"), "Монтана", "Монтана" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { new Guid("b11073b7-cd1c-4b2b-b186-bc906f9b3ff5"), "Хисаря", "Пловдив" },
                    { new Guid("b1c5544f-96a0-4d53-8e04-5bba47e857a0"), "Сандански", "Благоевград" },
                    { new Guid("b3b57d4e-ac90-46e5-875e-46bb01a9f7a0"), "Овощник", "Стара Загора" },
                    { new Guid("b5415f34-4435-4c98-a1e5-33067cb9cdd1"), "Хасково", "Хасково" },
                    { new Guid("b6681af7-adcf-4970-b8ea-040fb7420775"), "Китен", "Бургас" },
                    { new Guid("b7dc6946-a8e5-4093-800e-b0f6ee8b5ba3"), "Добрич", "Добрич" },
                    { new Guid("b9537eac-193f-4ca6-b3a8-fe80e90a5679"), "Самоков", "София" },
                    { new Guid("bc54993f-9aa4-4c30-8aab-e121c403704f"), "Павел Баня", "Стара Загора" },
                    { new Guid("c122482c-7443-42d6-ad68-247a898a5a45"), "Мелник", "Благоевград" },
                    { new Guid("c176e00d-b28d-47d8-958a-c9fbf6ff3810"), "Перник", "Перник" },
                    { new Guid("c5cce326-6b9e-42e3-8e30-a7c49f4a9f3d"), "Пазарджик", "Пазарджик" },
                    { new Guid("ca52c322-63e7-4bf2-b306-991fbf9e65fa"), "Дряново", "Габрово" },
                    { new Guid("cc8ce62a-b823-4350-99b8-f6f7ae24e09b"), "Клисура", "Пловдив" },
                    { new Guid("d585afd7-02df-4541-ac6d-98494ffe2832"), "Копривщица", "София" },
                    { new Guid("d5f6a059-6b12-482e-a38e-d8a507602a7a"), "Сапарева баня", "Кюстендил" },
                    { new Guid("de1738c1-2539-4ce7-b0a3-9ac124577fbc"), "Созопол", "Бургас" },
                    { new Guid("e1e04c10-4955-43a5-a4b3-7af5730695c6"), "Банско", "Благоевград" },
                    { new Guid("e4e13cf5-40af-4e0d-8b5c-735d5ed94f89"), "Елхово", "Ямбол" },
                    { new Guid("eabd8070-c77a-4f9c-95ac-01c963f60357"), "Ахелой", "Бургас" },
                    { new Guid("f024a1f5-103d-43bb-8c46-324ede24acd2"), "Габрово", "Габрово" },
                    { new Guid("f6e67d80-1420-4561-ab8c-003f9376c3db"), "Калофер", "Пловдив" },
                    { new Guid("fa81b7a1-ea1c-49a5-bf71-07fe9d663ad8"), "Карлово", "Пловдив" },
                    { new Guid("fdc105d3-64c6-45ce-b745-101c4a2dde83"), "Белоградчик", "Видин" },
                    { new Guid("fdec6cb0-0d98-4822-8bde-e1c6d1a18d6b"), "Петрич", "Благоевград" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("044f8d23-5412-48ee-9fe6-668c324ae009"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("08413d50-d3e3-45c7-aa06-d1359e6f304e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c54d9b6-96a3-404c-a8a0-9287147e1fe1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d34715f-adda-40b8-91f5-6e23c7af51a8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0efcd63f-9c19-4c59-9f4a-aa7f176074cd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("14310b9e-7430-4cff-a15c-72f06595992c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("167d8ef2-8de9-42e1-af96-59fc782c1d35"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("20a8a494-03ae-40c0-9474-c6bff742ff1e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("24bd9ff0-a4d8-481e-94a9-b481d1c1fbe5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("288f9b1f-bab8-4803-872c-6944e1dca17f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d7a97e5-a08e-4ea5-9630-e1c42976bd51"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2fcb9fae-5f5c-4536-b182-abfd609158e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("30cd2ee4-310f-4a25-986b-6f7d465c2a39"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("326211c7-1f7b-485a-ba88-8e376f5330e0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3c80c35f-610e-49f4-a473-4b00091b56a6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3d7476bb-b3da-4413-b76d-fa85ebad46ea"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("43320305-fd87-416f-af2f-0877e53c6382"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("44b9e06e-e3e6-46db-93e5-afe18afe1213"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("49af785e-2bdb-470e-a04a-c7509ea11990"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4d73d550-90f6-4418-bca5-565be40a1999"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5416b2f3-a698-44d5-a550-d712c08c2749"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("59b474c1-16e9-4e39-9c57-75a7633127a6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5ada3746-891b-4134-b935-5e5d88cb7c11"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5fc35891-eed5-4509-8365-0ce420bca8d4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("72ac0665-548e-411c-a4a3-2c821a88dd6c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7305a68d-615a-467d-a919-55ba6070d762"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("77c85120-5951-47e4-b743-3173d4093560"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("797a1392-bad9-4438-84ad-00e62a2038a1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7bf3a252-0562-4d55-a310-bd9ab4bca530"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("85c602c4-cfc8-43ae-8fdc-a0fc837eb3ce"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("88e9bb91-0881-4166-9c7f-9f519941375b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8ba23070-6733-40a8-b57d-e503f1d171a2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8bca9a4a-0d4c-4bca-97c5-eba270260c3e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9405b409-3790-411e-8988-029e13068487"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("96b45633-c16d-43d1-b81b-d5d449ba7d7c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9e17acee-abc1-41b6-a80f-93e982607675"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9fde9dd5-0b16-4a15-b1a4-0b2f9c6274a7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0bf7221-b30e-4236-b287-de4e94f445f1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a1900cc4-cf37-4bc1-8a30-0ed2c2a26731"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a80a0edc-3a48-430d-bb90-f11565535d16"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aeb6d0bc-a0fd-4ae1-9643-27c4a7060953"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("aecd9893-6691-405f-9109-7cdb9cea5791"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b11073b7-cd1c-4b2b-b186-bc906f9b3ff5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b1c5544f-96a0-4d53-8e04-5bba47e857a0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b3b57d4e-ac90-46e5-875e-46bb01a9f7a0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b5415f34-4435-4c98-a1e5-33067cb9cdd1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b6681af7-adcf-4970-b8ea-040fb7420775"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b7dc6946-a8e5-4093-800e-b0f6ee8b5ba3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b9537eac-193f-4ca6-b3a8-fe80e90a5679"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bc54993f-9aa4-4c30-8aab-e121c403704f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c122482c-7443-42d6-ad68-247a898a5a45"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c176e00d-b28d-47d8-958a-c9fbf6ff3810"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c5cce326-6b9e-42e3-8e30-a7c49f4a9f3d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ca52c322-63e7-4bf2-b306-991fbf9e65fa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cc8ce62a-b823-4350-99b8-f6f7ae24e09b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d585afd7-02df-4541-ac6d-98494ffe2832"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d5f6a059-6b12-482e-a38e-d8a507602a7a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("de1738c1-2539-4ce7-b0a3-9ac124577fbc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e1e04c10-4955-43a5-a4b3-7af5730695c6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e4e13cf5-40af-4e0d-8b5c-735d5ed94f89"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eabd8070-c77a-4f9c-95ac-01c963f60357"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f024a1f5-103d-43bb-8c46-324ede24acd2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f6e67d80-1420-4561-ab8c-003f9376c3db"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fa81b7a1-ea1c-49a5-bf71-07fe9d663ad8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fdc105d3-64c6-45ce-b745-101c4a2dde83"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fdec6cb0-0d98-4822-8bde-e1c6d1a18d6b"));

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Cities");

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Cities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Postcode" },
                values: new object[,]
                {
                    { new Guid("089cee59-8d4f-423e-9a78-73ea848c2f15"), "Панагюрище", "4500" },
                    { new Guid("09c77998-25f4-4f4f-855e-f215f31b5880"), "Разград", "7200" },
                    { new Guid("18ff4ca1-bf93-41c7-b4d4-2137afbc92ee"), "Велико Търново", "5000" },
                    { new Guid("2421f970-218f-479b-978d-9e88366b8e9b"), "Бяла", "9101" },
                    { new Guid("29edff2f-b90c-416d-bc1d-76d59f0e4dd9"), "Созопол", "8130" },
                    { new Guid("2a7db128-7c90-42c1-b84e-fe83fdc5b31d"), "Кърджали", "6600" },
                    { new Guid("2ae578f3-8491-4b7c-8160-114fa15905df"), "Силистра", "7500" },
                    { new Guid("2bfb43fc-b0b6-44f2-93a6-c6ae5882c24b"), "Карлово", "4300" },
                    { new Guid("315f22f8-40a3-48b2-be93-0d3482485e49"), "Елхово", "8700" },
                    { new Guid("33b7d571-24d6-4236-ab48-21dd2425d343"), "Сандански", "2800" },
                    { new Guid("3461f601-8778-46ea-9582-fdac3b66df9c"), "Лом", "3600" },
                    { new Guid("3d878ab3-b630-4a58-b847-8e002040a6c5"), "Пампорово", "4870" },
                    { new Guid("43f72542-bcea-4b32-9182-d8997f842665"), "Несебър", "8230" },
                    { new Guid("490fa1ba-5897-4c62-956b-c86ff971ab5a"), "Банско", "2770" },
                    { new Guid("4ae83a65-17a4-4577-94d8-44c6e702c624"), "Варна", "9000" },
                    { new Guid("4b658dec-69f0-4782-a8ff-d3a552e65f94"), "Благоевград", "2700" },
                    { new Guid("4c60e3ab-5e3e-45a0-8c2b-38b4056f8573"), "Банкя", "1320" },
                    { new Guid("4cb51ded-e6d0-42b3-98c6-676d8de4f475"), "Велинград", "4600" },
                    { new Guid("4ef1dcf6-cdd6-4cae-bb33-42c5a6f734ef"), "Хасково", "6300" },
                    { new Guid("51e415ee-5fcf-4172-a0dd-d66c6294cbbd"), "Самоков", "2000" },
                    { new Guid("532f2c58-0b50-4dd0-afce-43ea8f68495a"), "Плевен", "5800" },
                    { new Guid("5564d472-57ac-47eb-89ae-1974b01ab19a"), "Пловдив", "4000" },
                    { new Guid("55d782e4-c03e-4d0a-90ce-9a462fa4f41a"), "Балчик", "9600" },
                    { new Guid("5b9bc29e-dd91-41bc-90ae-6310136a2b6f"), "Бургас", "8000" },
                    { new Guid("5c94c9f1-cc6a-428b-99f1-0369510d463e"), "Враца", "3000" },
                    { new Guid("66d3467f-b3f1-4e77-9573-2dda8e3d606a"), "Казанлък", "6100" },
                    { new Guid("6941b9a2-39dd-4f83-8d8c-144cb0feb393"), "Китен", "8183" },
                    { new Guid("733981c7-bb24-4894-bae1-2d4dd2913322"), "Ахелой", "8217" },
                    { new Guid("734b45fe-a31e-4f85-8f46-0156095609d9"), "Калофер", "4370" },
                    { new Guid("73fb50f7-4e06-4e00-a6b2-32869dc36f11"), "Овощник", "6138" },
                    { new Guid("75be5e66-52a5-4f1a-9839-a74d2fece0ec"), "Обзор", "8250" },
                    { new Guid("77e0e509-1c7f-4aeb-b8c1-76ac458c5a59"), "Плиска", "9920" },
                    { new Guid("7a4aabc4-f512-4322-b05b-4f3b0e0f131b"), "Троян", "5600" },
                    { new Guid("7ba3675f-fc9b-4859-9e7a-729860906ef6"), "Симитли", "2730" },
                    { new Guid("80675a56-4212-425f-bc2c-4986871549ae"), "Сливен", "8800" },
                    { new Guid("82afabe5-80a5-42e4-a515-771ad102ceb8"), "Видин", "3700" },
                    { new Guid("8be05989-3cbf-4105-a6dd-8a81c9f83276"), "Хисаря", "4180" },
                    { new Guid("8ed045fe-7095-4edf-912b-1348cc019c1f"), "Свети власт", "8256" },
                    { new Guid("91aa7910-1422-488f-90c5-6e305a96f4f2"), "Белоградчик", "3900" },
                    { new Guid("943fe0a0-bb03-471c-9529-68417c68f1e8"), "Боровец", "2010" },
                    { new Guid("9a68ff87-04c0-4dac-a39c-e8759f5d127a"), "Копривщица", "2077" },
                    { new Guid("9af0f7b7-d3d9-4beb-beda-bfc99ef9ff43"), "Шумен", "9700" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Postcode" },
                values: new object[,]
                {
                    { new Guid("a0a45b4c-c1b8-4e94-a8de-181c4bdfb2f8"), "Търговище", "7700" },
                    { new Guid("a0ff2b6a-b818-4730-852c-a1fae4f7e3ca"), "Монтана", "3400" },
                    { new Guid("a4ebdb24-9aeb-41d9-a91d-bd1199eacd9e"), "Пазарджик", "4400" },
                    { new Guid("a8da022b-c68a-4131-b96f-837f45de04a7"), "Кюстендил", "2500" },
                    { new Guid("abfca343-73c5-4bc4-bc1e-902afe12c6e1"), "Мелник", "2820" },
                    { new Guid("af650f80-c8ba-4c2a-9c3d-10e7f4f00d03"), "София", "1000" },
                    { new Guid("af6ef6c7-ade0-4181-8ab2-c62eb668e542"), "Петрич", "2850" },
                    { new Guid("b05bc648-73cc-4b18-91ba-4a435f7f3080"), "Клисура", "4341" },
                    { new Guid("b2d8b92d-7fa1-41f3-b403-76c8d4ffd140"), "Ямбол", "8600" },
                    { new Guid("ba1d4e11-c8c0-4ed5-884a-98e07b8b476b"), "Перник", "2300" },
                    { new Guid("c18d9fe5-222c-48b4-91fa-e6d73e781e18"), "Айтос", "8500" },
                    { new Guid("cb78b846-a0c3-43f3-ac39-ecc25c92bafe"), "Смолян", "4700" },
                    { new Guid("d55f6e7e-f851-446e-9916-69c578d4c8ec"), "Дряново", "5370" },
                    { new Guid("d6416941-a431-4dd1-b07a-fd6e49bfa396"), "Сапарева баня", "2650" },
                    { new Guid("daf095b3-fadb-4d04-a6a4-5bc30d16ca6b"), "Нова Загора", "8900" },
                    { new Guid("dbdc4b23-e7dc-4487-9f71-6b6411710f54"), "Баня", "4360" },
                    { new Guid("e13c2d1a-b03a-4dd3-bed9-d3160194d871"), "Стара Загора", "6000" },
                    { new Guid("e33adc42-c19e-4cef-8795-32601062f06d"), "Габрово", "5300" },
                    { new Guid("eb5a75bf-6652-47ee-8d63-3f8236bbaaca"), "Ловеч", "5500" },
                    { new Guid("efca9570-a0a5-4e02-aafc-3d118b0be0ac"), "Павел Баня", "6155" },
                    { new Guid("f2ae187d-bc51-48fc-85e0-ea4955dc3a56"), "Русе", "7000" },
                    { new Guid("f61f0c9f-9955-44cb-aa52-08b49e1d38e9"), "Доспат", "4831" },
                    { new Guid("f7ca3216-839b-4b38-95a7-f8c682cce095"), "Добрич", "9300" },
                    { new Guid("fdf7c7e9-7bfd-4e25-b273-a66793db40f4"), "Трявна", "5350" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Postcode",
                table: "Cities",
                column: "Postcode",
                unique: true);
        }
    }
}
