using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class oneToOneLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Facilities_ResortId",
                table: "Facilities");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("05c313a7-ffd3-4bf8-87d9-d8e5810faa16"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("07321864-35bc-43dc-9c18-ae77cfbefb6c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("08b4a24b-9c76-45b0-8f42-75d9c41d3420"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0ed54bf7-21f3-4c43-809b-adcf518d532e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0f9ea82f-516a-4614-ae02-8739d295048d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1949950e-2f36-4661-ad9c-4fd37ee3bfb2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("19867dc6-4440-47bb-ad0b-bccbf4690ae2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1f0a4e54-6b06-4590-8d5b-35378401d7b7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("22df4d60-7bdf-4300-90a8-63416d4d634e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("22f87304-1e51-4894-b26b-68dda5bd58d6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("28b1e810-2881-4477-9434-f4e313d61cbd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d86004a-a9df-4ec5-b89c-1605eb90f6be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2e991b9c-ccb2-42f8-bf26-d22804a27afa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("30f5fe6a-ebc9-4412-af57-1dfb50945b94"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("311d6ec1-c1b2-4ab5-b61b-eca6e37e48f2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("313ea8e1-1fcf-4883-971a-9328de8afcd2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("326b7068-b69e-401e-91b6-6aafc3dfccee"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("36e011ae-118a-4308-87fd-9a71da797e6d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("377ddffc-51a3-4916-9fef-4ee038bedf79"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3789dc36-439b-4f2b-a320-26bf550519dc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a77b379-1463-4376-a286-2985ec78f764"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3af70f39-fdd5-4278-af80-65c93098adc8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3d5764a2-1440-4fe6-b54a-04a398c97e0f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("45c08cfb-939b-4b38-b122-6c33bfce2ef4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("45d28d59-6900-4377-a759-8faab886c902"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4864db5e-9e61-4499-991e-dd0da677f10c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("499ec3c7-6a33-49d9-bb6f-5aaf3a2102fc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b0dcc08-ebed-4474-8409-3ec4b8297e68"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b5cee03-d157-4173-823b-9334edbd69b0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("54d58ebe-3045-4dcb-bae9-00f3051821cb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("61d16beb-e73e-42ff-8cc7-dc20c170553d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("660c567a-88a7-463f-89d9-4c8d9fba2308"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6a8ad875-a18d-4e94-8c60-5a72378512d1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6d2fd540-9434-4578-aa7a-37cef9170eb5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6e21cd96-38e3-4112-be0d-1cedb6995b7e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("73089b06-ff6b-4915-8e8b-354e561eb596"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7afbe610-c374-429d-bbaf-b34971e09fe8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("82e4b17e-3398-48e8-ab44-0303a5c6bf44"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("896dc06e-b6f0-4a7c-a548-d1de5f778941"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8c1aa934-9dc7-40a7-a38b-8138db93aec8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("90208cf8-1d3c-4dd3-91b7-8bb9a5d65867"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("93b28713-0fcf-44d7-96ec-de7eec561f8c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("97ec01c8-86e0-4242-af7c-215b78980db1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("989ee7d3-f338-4939-bd4d-0aa14675ebb8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9a508bc6-bb93-403f-8117-63f0ecb8a025"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a42a4112-98eb-41ac-8fec-e6af40a32358"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a4307b3d-d239-43bd-9765-b47f0392210d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a623d9d4-7d91-461a-910f-98cf318e5bd2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b6cb0456-8881-436c-8923-f5ded497d3e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c4a27fef-1d43-491a-a29d-87b11eaa7760"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c80ffefe-e508-4b01-92b6-77b17f6ff418"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c9872d01-68da-477e-871a-89c56589ec00"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cbc55d4a-debb-4338-aa60-d5d9ccc42a77"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d2e27bed-0fd7-4768-b54f-abbe7f23a049"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d3a46fed-cb8b-4451-b924-ca3529632627"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e005296d-1aa5-443f-b0b7-dd9d6b4c2abe"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e455a56e-62a6-4411-9f56-456ddee526a4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e6c1f69f-f20c-4cc0-95ec-6d61369de539"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e74166a7-796e-4cf0-a370-b6dc57cd882c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e7b742e1-8845-4bd2-a724-a67c13ac6e32"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f43cdf33-50bd-4fe5-a01c-76c50659d97e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f5c43a08-491d-4d59-a8d4-13dd3637fa57"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f8b23e01-403d-414c-8a26-493836ed0dcc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fa4160ef-30ea-4cbb-ac86-ead343c68a34"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fc4ab2ab-04f0-4127-8493-97381f3d69f2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ff0ea395-6d82-4081-95dd-e7d3c1a16249"));

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
                name: "IX_Facilities_ResortId",
                table: "Facilities",
                column: "ResortId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Facilities_ResortId",
                table: "Facilities");

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Postcode" },
                values: new object[,]
                {
                    { new Guid("05c313a7-ffd3-4bf8-87d9-d8e5810faa16"), "Добрич", "9300" },
                    { new Guid("07321864-35bc-43dc-9c18-ae77cfbefb6c"), "Казанлък", "6100" },
                    { new Guid("08b4a24b-9c76-45b0-8f42-75d9c41d3420"), "Копривщица", "2077" },
                    { new Guid("0ed54bf7-21f3-4c43-809b-adcf518d532e"), "Доспат", "4831" },
                    { new Guid("0f9ea82f-516a-4614-ae02-8739d295048d"), "Симитли", "2730" },
                    { new Guid("1949950e-2f36-4661-ad9c-4fd37ee3bfb2"), "Пазарджик", "4400" },
                    { new Guid("19867dc6-4440-47bb-ad0b-bccbf4690ae2"), "Дряново", "5370" },
                    { new Guid("1f0a4e54-6b06-4590-8d5b-35378401d7b7"), "Петрич", "2850" },
                    { new Guid("22df4d60-7bdf-4300-90a8-63416d4d634e"), "Варна", "9000" },
                    { new Guid("22f87304-1e51-4894-b26b-68dda5bd58d6"), "Банско", "2770" },
                    { new Guid("28b1e810-2881-4477-9434-f4e313d61cbd"), "Мелник", "2820" },
                    { new Guid("2d86004a-a9df-4ec5-b89c-1605eb90f6be"), "Кюстендил", "2500" },
                    { new Guid("2e991b9c-ccb2-42f8-bf26-d22804a27afa"), "Стара Загора", "6000" },
                    { new Guid("30f5fe6a-ebc9-4412-af57-1dfb50945b94"), "Плевен", "5800" },
                    { new Guid("311d6ec1-c1b2-4ab5-b61b-eca6e37e48f2"), "Хисаря", "4180" },
                    { new Guid("313ea8e1-1fcf-4883-971a-9328de8afcd2"), "Клисура", "4341" },
                    { new Guid("326b7068-b69e-401e-91b6-6aafc3dfccee"), "Карлово", "4300" },
                    { new Guid("36e011ae-118a-4308-87fd-9a71da797e6d"), "Китен", "8183" },
                    { new Guid("377ddffc-51a3-4916-9fef-4ee038bedf79"), "Хасково", "6300" },
                    { new Guid("3789dc36-439b-4f2b-a320-26bf550519dc"), "Трявна", "5350" },
                    { new Guid("3a77b379-1463-4376-a286-2985ec78f764"), "Кърджали", "6600" },
                    { new Guid("3af70f39-fdd5-4278-af80-65c93098adc8"), "Търговище", "7700" },
                    { new Guid("3d5764a2-1440-4fe6-b54a-04a398c97e0f"), "Свети власт", "8256" },
                    { new Guid("45c08cfb-939b-4b38-b122-6c33bfce2ef4"), "Перник", "2300" },
                    { new Guid("45d28d59-6900-4377-a759-8faab886c902"), "Овощник", "6138" },
                    { new Guid("4864db5e-9e61-4499-991e-dd0da677f10c"), "Габрово", "5300" },
                    { new Guid("499ec3c7-6a33-49d9-bb6f-5aaf3a2102fc"), "Бяла", "9101" },
                    { new Guid("4b0dcc08-ebed-4474-8409-3ec4b8297e68"), "Сапарева баня", "2650" },
                    { new Guid("4b5cee03-d157-4173-823b-9334edbd69b0"), "Обзор", "8250" },
                    { new Guid("54d58ebe-3045-4dcb-bae9-00f3051821cb"), "Сливен", "8800" },
                    { new Guid("61d16beb-e73e-42ff-8cc7-dc20c170553d"), "Плиска", "9920" },
                    { new Guid("660c567a-88a7-463f-89d9-4c8d9fba2308"), "Велико Търново", "5000" },
                    { new Guid("6a8ad875-a18d-4e94-8c60-5a72378512d1"), "Созопол", "8130" },
                    { new Guid("6d2fd540-9434-4578-aa7a-37cef9170eb5"), "Бургас", "8000" },
                    { new Guid("6e21cd96-38e3-4112-be0d-1cedb6995b7e"), "Белоградчик", "3900" },
                    { new Guid("73089b06-ff6b-4915-8e8b-354e561eb596"), "Пампорово", "4870" },
                    { new Guid("7afbe610-c374-429d-bbaf-b34971e09fe8"), "Пловдив", "4000" },
                    { new Guid("82e4b17e-3398-48e8-ab44-0303a5c6bf44"), "Ахелой", "8217" },
                    { new Guid("896dc06e-b6f0-4a7c-a548-d1de5f778941"), "Балчик", "9600" },
                    { new Guid("8c1aa934-9dc7-40a7-a38b-8138db93aec8"), "Сандански", "2800" },
                    { new Guid("90208cf8-1d3c-4dd3-91b7-8bb9a5d65867"), "Самоков", "2000" },
                    { new Guid("93b28713-0fcf-44d7-96ec-de7eec561f8c"), "Видин", "3700" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Postcode" },
                values: new object[,]
                {
                    { new Guid("97ec01c8-86e0-4242-af7c-215b78980db1"), "Силистра", "7500" },
                    { new Guid("989ee7d3-f338-4939-bd4d-0aa14675ebb8"), "София", "1000" },
                    { new Guid("9a508bc6-bb93-403f-8117-63f0ecb8a025"), "Айтос", "8500" },
                    { new Guid("a42a4112-98eb-41ac-8fec-e6af40a32358"), "Павел Баня", "6155" },
                    { new Guid("a4307b3d-d239-43bd-9765-b47f0392210d"), "Баня", "4360" },
                    { new Guid("a623d9d4-7d91-461a-910f-98cf318e5bd2"), "Благоевград", "2700" },
                    { new Guid("b6cb0456-8881-436c-8923-f5ded497d3e2"), "Панагюрище", "4500" },
                    { new Guid("c4a27fef-1d43-491a-a29d-87b11eaa7760"), "Ямбол", "8600" },
                    { new Guid("c80ffefe-e508-4b01-92b6-77b17f6ff418"), "Монтана", "3400" },
                    { new Guid("c9872d01-68da-477e-871a-89c56589ec00"), "Смолян", "4700" },
                    { new Guid("cbc55d4a-debb-4338-aa60-d5d9ccc42a77"), "Троян", "5600" },
                    { new Guid("d2e27bed-0fd7-4768-b54f-abbe7f23a049"), "Русе", "7000" },
                    { new Guid("d3a46fed-cb8b-4451-b924-ca3529632627"), "Велинград", "4600" },
                    { new Guid("e005296d-1aa5-443f-b0b7-dd9d6b4c2abe"), "Лом", "3600" },
                    { new Guid("e455a56e-62a6-4411-9f56-456ddee526a4"), "Ловеч", "5500" },
                    { new Guid("e6c1f69f-f20c-4cc0-95ec-6d61369de539"), "Враца", "3000" },
                    { new Guid("e74166a7-796e-4cf0-a370-b6dc57cd882c"), "Елхово", "8700" },
                    { new Guid("e7b742e1-8845-4bd2-a724-a67c13ac6e32"), "Шумен", "9700" },
                    { new Guid("f43cdf33-50bd-4fe5-a01c-76c50659d97e"), "Несебър", "8230" },
                    { new Guid("f5c43a08-491d-4d59-a8d4-13dd3637fa57"), "Банкя", "1320" },
                    { new Guid("f8b23e01-403d-414c-8a26-493836ed0dcc"), "Калофер", "4370" },
                    { new Guid("fa4160ef-30ea-4cbb-ac86-ead343c68a34"), "Нова Загора", "8900" },
                    { new Guid("fc4ab2ab-04f0-4127-8493-97381f3d69f2"), "Разград", "7200" },
                    { new Guid("ff0ea395-6d82-4081-95dd-e7d3c1a16249"), "Боровец", "2010" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_ResortId",
                table: "Facilities",
                column: "ResortId");
        }
    }
}
