﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guests = table.Column<int>(type: "int", nullable: false),
                    RoomCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Landmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landmarks_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resorts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stars = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resorts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resorts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationUser",
                columns: table => new
                {
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationUser", x => new { x.UserId, x.ReservationId });
                    table.ForeignKey(
                        name: "FK_ReservationUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationUser_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Wifi = table.Column<bool>(type: "bit", nullable: false),
                    Parking = table.Column<bool>(type: "bit", nullable: false),
                    Pool = table.Column<bool>(type: "bit", nullable: false),
                    Restaurant = table.Column<bool>(type: "bit", nullable: false),
                    Gym = table.Column<bool>(type: "bit", nullable: false),
                    SpaCenter = table.Column<bool>(type: "bit", nullable: false),
                    RoomService = table.Column<bool>(type: "bit", nullable: false),
                    ResortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facilities_Resorts_ResortId",
                        column: x => x.ResortId,
                        principalTable: "Resorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResortId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Resorts_ResortId",
                        column: x => x.ResortId,
                        principalTable: "Resorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomReservation",
                columns: table => new
                {
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomReservation", x => new { x.ReservationId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_RoomReservation_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomReservation_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "528726ea-e421-4a80-b303-f035355599de", "ab2a5b15-b1b7-43cf-a527-a3dc529a4226", "Administrator", "ADMINISTRATOR" },
                    { "5dd65fa9-eb2c-4372-8084-8c501347e74f", "dfe29b01-f9c3-4131-b1d2-d36605aeee8f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d2536968-519d-42d7-9f8a-c14e56bad4ac", 0, "05f60ff6-d966-4be8-9d85-96142733bfb2", "george@abv.bg", false, "Георги", null, "Иванов", false, null, "GEORGE@ABV.BG", "GEORGE", "AQAAAAEAACcQAAAAEGhxpFe5tskdI5Q9UnYwqGxfbn7CVfzTO5TKa3yjeCyh3rBd11gCMQr2zrONlLqTqg==", null, false, "e6afe6d2-c43a-487a-9020-572f01f0e979", false, "George" },
                    { "e067e587-1b89-4dfb-a7dd-cee434dcfc0b", 0, "c9623b76-5d0f-4053-9971-ead95f49932a", "dimitar@abv.bg", false, "Димитър", null, "Димитров", false, null, "DIMITAR@ABV.BG", "MEETYOU", "AQAAAAEAACcQAAAAELua7nrApLfnHXyDVJgpTn2UaCeDTklDFstZ9sB6cvj2vX+GBWzlWzsDJfAKMJWi2Q==", null, false, "3d3acb0e-d45b-4f44-ae4c-83b8d38057da", false, "MeetYou" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { new Guid("006902e5-3b36-42da-a288-77a33f44f021"), "Кюстендил", "Кюстендил" },
                    { new Guid("0241e7d1-b7b8-4fa6-a140-0c1075fab0f6"), "Айтос", "Бургас" },
                    { new Guid("0448b74c-0a38-45b8-a836-f6e426394fa8"), "Доспат", "Смолян" },
                    { new Guid("073c2020-0af2-4bee-a3a6-d81c9d479c4b"), "Банкя", "София" },
                    { new Guid("0b0762c1-37f0-4a14-a2f9-585e50b4c70d"), "Несебър", "Бургас" },
                    { new Guid("0b2d14c1-b888-428d-8122-e32623a22537"), "Клисура", "Пловдив" },
                    { new Guid("162c6340-19d3-4661-89bb-8b7ccfa669e9"), "Казанлък", "Стара Загора" },
                    { new Guid("1cd1baea-c219-4ba7-bf46-bc154464782b"), "Дряново", "Габрово" },
                    { new Guid("1e72e4f6-588e-42e6-b93b-9122458547d5"), "Перник", "Перник" },
                    { new Guid("1e759da7-e6ff-42dc-b35d-428e793cc5ad"), "Троян", "Ловеч" },
                    { new Guid("233afddf-48f2-429a-834b-c851f4679d87"), "Пловдив", "Пловдив" },
                    { new Guid("237fb6a1-e2f2-4750-aa2c-bbe3e9872d65"), "Сандански", "Благоевград" },
                    { new Guid("2567149f-2705-437b-9f2d-12da1b8e20e8"), "Трявна", "Габрово" },
                    { new Guid("283a59a6-77c5-4b38-a579-05086cd4c375"), "Плевен", "Плевен" },
                    { new Guid("3efe9a18-62e8-4ede-b3ef-a411e6136862"), "Велико Търново", "Велико Търново" },
                    { new Guid("425cda45-30a8-4574-9394-6e7281e6c19a"), "Свети Влас", "Бургас" },
                    { new Guid("444c2d73-bb42-4f55-83d3-8930a7257f2e"), "Благоевград", "Благоевград" },
                    { new Guid("47181a59-c6c1-42ff-8304-10b56c9f59fe"), "Добрич", "Добрич" },
                    { new Guid("48a438e7-5d75-4a51-8076-de210c7f6323"), "Габрово", "Габрово" },
                    { new Guid("48d5bcd4-c99e-4796-8843-852cae764175"), "Кърджали", "Кърджали" },
                    { new Guid("494eece5-d5df-469f-b878-86eaab056aaf"), "Мелник", "Благоевград" },
                    { new Guid("51dc4e13-81e3-4945-9fce-776d9a76b244"), "Бяла", "Варна" },
                    { new Guid("591ae964-8f25-4676-b4bc-713ded8ede5d"), "Ямбол", "Ямбол" },
                    { new Guid("5bc79020-4a92-43fb-9c97-7550bdc8f6c9"), "Варна", "Варна" },
                    { new Guid("5c0a26b7-dd86-4b8f-95e6-93910b86a2c2"), "Копривщица", "София" },
                    { new Guid("5e54d07a-4bc1-49fa-9196-45f5946f4791"), "Обзор", "Варна" },
                    { new Guid("666210cb-cca9-4b3d-a583-371dffaa43c3"), "Ахелой", "Бургас" },
                    { new Guid("6ba29df6-f14e-4096-a055-352aef819261"), "Хасково", "Хасково" },
                    { new Guid("6d207c13-2e2c-454f-9ae6-ce724732a37a"), "Сапарева баня", "Кюстендил" },
                    { new Guid("730ffb2e-f234-4dff-85f4-c95d4a03c4b7"), "Хисаря", "Пловдив" },
                    { new Guid("76500059-135a-425f-8aa3-f9b1110cecdf"), "Ловеч", "Ловеч" },
                    { new Guid("78f4e52c-8d18-40e3-b3e4-65049a45f738"), "Монтана", "Монтана" },
                    { new Guid("7a65d489-304c-4be8-b344-7d53a644e080"), "Самоков", "София" },
                    { new Guid("833246ee-f3be-4337-b84a-a0cc58f22558"), "Пазарджик", "Пазарджик" },
                    { new Guid("87f7cbb5-e683-4748-9a1a-d8df1b85a3c9"), "Плиска", "Шумен" },
                    { new Guid("8ac44425-1406-47e4-b8b1-4349f8417d9e"), "Сливен", "Сливен" },
                    { new Guid("9797d486-63d8-450e-b339-385dca0caa5e"), "Симитли", "Благоевград" },
                    { new Guid("9ab891a5-96ca-446f-8d2f-708b1f3230a8"), "Карлово", "Пловдив" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { new Guid("9d1d0c7c-daa1-4941-91b4-db28a7da4e03"), "Бургас", "Бургас" },
                    { new Guid("9f349c56-8bae-4a9f-ab45-01a26f210fc4"), "Петрич", "Благоевград" },
                    { new Guid("a48e9933-b26b-4315-ae4a-99583f912f0f"), "Китен", "Бургас" },
                    { new Guid("a51a3b6b-59e9-4b38-814f-a90483b12a71"), "Смолян", "Смолян" },
                    { new Guid("a6094c67-3d3b-4f06-9bdf-320df7e8e236"), "Шумен", "Шумен" },
                    { new Guid("aaaf83c1-5b37-4bc9-9260-2ee6725fe657"), "Боровец", "София" },
                    { new Guid("ad6ceeeb-1a59-415c-8a8e-1eaac8c13956"), "Банско", "Благоевград" },
                    { new Guid("ba5cd8db-1c24-4326-9520-419b1b6189b4"), "Созопол", "Бургас" },
                    { new Guid("bad041da-8d53-474a-97de-8693510f64ae"), "Видин", "Видин" },
                    { new Guid("c0729f5e-992e-400d-9b73-7c4c342dd817"), "Русе", "Русе" },
                    { new Guid("cfa4fd70-a58b-42cc-abba-bde82ff342d1"), "Панагюрище", "Пазарджик" },
                    { new Guid("d1a3a0d9-336d-4578-9373-3188cb960ebd"), "Калофер", "Пловдив" },
                    { new Guid("d24f0d58-974b-4d0f-a2e6-008c8fc1e9cf"), "Балчик", "Добрич" },
                    { new Guid("d36b4336-8391-4da7-b0df-e7a2555d07f6"), "Павел Баня", "Стара Загора" },
                    { new Guid("d7f43f14-7fd6-4416-bb24-067cc0d4beeb"), "Разград", "Разград" },
                    { new Guid("db024efc-a028-427f-98c9-a43df3ecf9e8"), "Белоградчик", "Видин" },
                    { new Guid("dba1ef66-4954-4c89-b67c-68974d455873"), "Баня", "Пловдив" },
                    { new Guid("e0c905d8-4828-48dc-8174-a6f131058c00"), "Нова Загора", "Сливен" },
                    { new Guid("e28de390-7ad8-433d-b84b-2229791c65f0"), "Стара Загора", "Стара Загора" },
                    { new Guid("e410ecba-3cd7-4e74-beb1-74047276f450"), "Пампорово", "Смолян" },
                    { new Guid("eb34a53b-0d2d-4e5e-9566-72eb48e5d57d"), "Елхово", "Ямбол" },
                    { new Guid("ed910cd8-575a-4329-a93c-ef5a14cc956d"), "Враца", "Враца" },
                    { new Guid("ee557af5-b2a1-4404-9e82-72c3a699c623"), "Велинград", "Пазарджик" },
                    { new Guid("f612bb1f-975e-434a-920b-5c886ebe3cc6"), "Овощник", "Стара Загора" },
                    { new Guid("f7e3ef46-c077-48db-9655-dfbb6849b39f"), "София", "София" },
                    { new Guid("fa995e10-4149-4267-a7eb-3c3059438071"), "Търговище", "Търговище" },
                    { new Guid("fae0374e-1581-4790-9a19-44f9323cd9fe"), "Лом", "Монтана" },
                    { new Guid("ff1c955c-57c1-4eaf-b17f-4f44e01fd4a8"), "Силистра", "Силистра" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5dd65fa9-eb2c-4372-8084-8c501347e74f", "d2536968-519d-42d7-9f8a-c14e56bad4ac" },
                    { "528726ea-e421-4a80-b303-f035355599de", "e067e587-1b89-4dfb-a7dd-cee434dcfc0b" }
                });

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("110944c0-cc62-4689-85ad-b5628cce6701"), new Guid("e28de390-7ad8-433d-b84b-2229791c65f0"), "Шипка е връх в Стара Планина, с надморска височина 1326 метра, разположен на изток от Шипченския проход. До 1951 г. върхът носи името Свети Никола, а до 1977г. – връх Столетов. Върхът символизира героизма и самопожертвователните усилия за освобождението на България от Османско робство. През 1934 г. на върха е построен Паметникът на свободата, до който водят автомобилен път и каменно стълбище. Паметникът е част от Парк-музей „Шипка“. Шипка се нарича и върхът (с височина 1232 м), разположен на север от главното било и на запад от Шипченския проход. Идеята за построяването на паметника е предложена по време на Учредителното народна събрание на 13 април 1879 година от народните представители Петко Каравелов, Петър Берон и Петко Р. Славейков. Народният поет Петко Славйков излиза с предложение в строителството на паметника да участва целият български народ, защото „… този паметник ще послужи в бъдеще като пътеводна звезда за нашето възсъединение, той ще привлича хората и ще събира в едно погледите на българите от всички краища на България“. Той представлява огромен каменен блок с форма на пресечена пирамида и по своето архитектурно оформление напомня крепостните съоръжения от времето на средновековната българска държава. Състои се от цокълен етаж /гробница/ и още пет етажа нагоре, където било замислено да се създаде музей. Над главния вход, на специална площадка, е поставена фигурата на лъв с височина 4 метра и дължина 8 метра – символ на величавия подвиг на героите на Шипка. В горната част на паметника на северната стена с метални букви е изписано „На борците за свободата“, а на останалите стени е написано: „Шипка“, „Шейново“ и „Стара Загора“ – тези имена напомнят за местата на сраженията, в които българските опълченци, заедно с руските воини, са влизали в решителен бой с врага. Висок е 31,50 метра.", "https://vr.penchochukov.com/uploads/images/tmb2/31_33.jpg", "Връх Шипка" },
                    { new Guid("124dcedd-d400-407f-ad09-d555c174e5fc"), new Guid("fa995e10-4149-4267-a7eb-3c3059438071"), "Крепостта Мисионис, известна още като Крумово кале, е един от най-значимите исторически паметници в България. Строена по времето на император Юстиниан І в края на V век, като част от отбранителната система на Византия, днес крепостта Крумово кале разкрива все повече от дълговековната си история и удивява и учени, и туристи. Според археологическите проучвания, Мисионис бил опожарен от варварските нашественици през VIв. С идването на българите на Балканския полуостров, той отново е възстановен и по време на битката с император Никифор става известен като Крумово кале. Средновековното българско селище било тясно свързано с културата и икономическото развитие на намиращата се в близост столица Велики Преслав. По време на Втората българска държава /ХІІ-ХІVв./ крепостта се превръща в голям търговски център с площ около 700 дка. Разрушена е окончателно при нашествието на османските завоеватели в края на ХІVв. Тогава населението на големия и развит античен и средновековен град (който по това време се е наричал Косово) се премества и установява в равнината, където е съществувало малко селище. Градът започва да носи турското име Ески Джумая, което в превод означава „стар, древен, петъчен пазар”.", "https://www.fixstay.com/uploads/images/original/139_2253.jpg", "Крепост Мисионис" },
                    { new Guid("14ceac29-39c3-482b-b0d7-ff163d408340"), new Guid("bad041da-8d53-474a-97de-8693510f64ae"), "Белоградчишките скали са скални образувания, образувани при изветряването на триаски пясъчници и конгломерати. Скалите се разпростират на приблизително 30 км дължина, 3 до 5 км ширина и до 200 м височина. Белоградчишките скали са обявени за природна забележителност от 1949 година. Този възхитителен природен феномен е изваян от стичащата се дъждовна вода и ветровете в продължение на 200 милиона години, превръщайки безформения камък в скулптури наподобяващи митични същества, човешки силуети, животни и птици. В края на Палеозоя, преди около 230 млн.г., в този район се наслоили песьчливо-мергелни скали. По-кьсно те били заляти от море, на дъното на което се отлагали пясък, чакъл и глина. С течение на времето тези материали били свързани от пясъчно-глинеста спойка. Така се получили конгломерати и пясъчници. Червеникавият цвят се дължи на железните окиси и хидроокиси. Като резултат на младоалпийския тектонски цикъл комплексът се нагънал и се показал на сушата, като районът на Белоградчик попаднал в центъра на една голяма пукнатина. Под влияние на водата, ветровете и колебанията на температурата варовиците от тези части се разрушили и разкрили силно напуканите конгломерати. Така в продължение на милиони години природата е изваяла от безформения камък скулптури на митични същества, хора, животни и птици. В пясъчника и варовика се образували и над 100 пещери. Тези скални колони, образуват естествена крепост, чийто отбранителен потенциал е бил експоатиран от древни времена. Скалите наподобяват хора, животни, замъци, пирамиди. Най-величествените скали обграждат Белоградчик: Мадоната, Конникът, Монасите, Ученичката, Лъвът, Мечката, Адам и Ева, Замъкът.", "https://bookvila.bg/img/210209073509-0.png", "Белографчишките скали" },
                    { new Guid("17730132-4ab4-40d1-9c76-db31ee439b48"), new Guid("48a438e7-5d75-4a51-8076-de210c7f6323"), "На 16 км. източно от гр. Габрово, на 750 м надморска височина, разположен на двата бряга на река Божанка се намира Архитектурно-исторически резерват Боженци. Селото е малко, но с повече от 600-годишна история. Запазило е автентичния си старинен вид от епохата на Възраждането, както и ценни архитектурни и етнографски паметници. Легендата разказва, че при падането на Търново под турско робство, овдовялата болярка Божана тръгва с децата си да търси убежище. На това място в Балкана, Божана спира и поставя първия камък на селището, което по-късно е кръстено на нейно име. Социално-икономическият подем в България през 18-ти век оказва благоприятно влияние и в селото започва бърз икономичеки подем. Населението се занимава предимно с търговия. Главни стоки са меда, кожите, вълната. Замогнало се чрез развитието на животновъдството, занаятите и търговията, селото променя и архитектурния си облик. Боженските къщи са имат висок долен етаж, външно стълбище и веранда, от която се влиза в гостна, после в кухня. Обзавеждането е впечатляващо - стените са с дървена облицовка, таваните - резбовани и украсени с разнообразни мотиви. Високите каменни огради, кованите дъбови врати, малките калдаръмени улички, каменните чешми и мостове носят неповторима атмосфера. В наши дни са останали над 100 къщи с над 100-250 годишна история. Населението наброява 40 души. От 1964 г. с.Боженци е обявено за архитектурно-исторически резерват. ", "https://marshrutibg.com/wp-content/uploads/%D0%B1%D0%BE%D0%B6-1.jpg", "Боженци" },
                    { new Guid("1a0e5aae-30da-47a3-b526-d90989746dba"), new Guid("c0729f5e-992e-400d-9b73-7c4c342dd817"), "В долината на река Русенски Лом, Североизточна България, в близост до село Иваново един комплекс от църкви, параклиси, манастири, издълбани в скалите, се е развивал в продължение на векове. Това са Ивановските скални църкви – един от деветте български паметника, вписан през 1979 г. в листата на ЮНЕСКО за световното културно и природно наследство. Първите отшелници са издълбали килиите си там още през XII век. А стенописите от XIV век свидетелстват за високоразвито художествено майсторство, характерно за живописната школа на старата българска столица Търново. Ивановските скални църкви се намират на 22 километра южно от крайдунавския град Русе и представляват разклонена мрежа от около 20 малки скални църкви, параклиси и килии, издълбани на различна височина в скалите на живописния каньон на река Русенски Лом и свързани с пътеки и скални стълби. Някога скалните църкви са били над 40, а килиите - около 300. Те са били обитавани от монаси, много от които граматици и книжовници, а християните отивали там на поклонение. Български царе и боляри от епохата на Второто българско царство (XII -XIV век) са изпращали каменоделци да издълбаят в скалите нови храмове, а зографи да ги изпишат със светите изображения.", "https://historymuseum.org/wp-content/uploads/2022/09/size_x628_5afdc9ffe2f27.jpg", "Ивановски скални църкви" },
                    { new Guid("248afb83-5e3d-4874-aa45-98534d8b23b6"), new Guid("48a438e7-5d75-4a51-8076-de210c7f6323"), "Манастирът \"Св. Архангел Михаил\" е основан през Втората българска държава - началото на XII век в местността Църквището - в непосредствена близост до лятната резиденция на българските царе от Асеновата династия. По време на турското робство манастирът на два пъти е разрушаван и ограбван (ХІV и ХVІІ в.), но и бързо възстановяван, за да остане здрава твърдина на българския дух. На сегашното си място е възобновен през 1845 година, когато е построена е малката, вкопана в земята църква \"Св. Архангел Михаил\". Тя е каменна и безкуполна с осмостенна камбанария. Еднокорабната църква \"Успение Пресветая Богородица\" е от 1861 г., а иконостасът й е изработен през 1876 г. от Н. Йонков. Манастирът е бил крепост и убежище на българските будители и революционери. По време на Национално-освободителните борби е посещаван на няколко пъти от отец Матей Преображенски (Миткалото), а през 1871 г. - и от Васил Левски. През 1876 г., по време на Априлското въстание, тук се укрива четата на поп Харитон и с участието на Бачо Киро. След деветдневни сражения с многохилядна турска войска четата е разгромена, а манастирът е опожарен и разрушен до основи. Възобновен е през 1880 г., а през 1897 г. на мястото на построената през 1861 г. църква \"Успение Богородично\" е издигнат паметник-костница на загиналите въстаници", "https://drumivdumi.com/wp-content/uploads/2020/03/0drqnovski_manastir_7218.jpg", "Дряновският манастир" },
                    { new Guid("2cba6922-0fec-4f37-a26c-e75a7bfa74d6"), new Guid("48d5bcd4-c99e-4796-8843-852cae764175"), "Природната забележителност се намира в землището на с. Зимзелен, на 3 кm от Кърджали. Изключително красива група от множество каменни пирамиди, напомняща сватбено шествие. Фигурите са изключително разнообразни по форма и размери, като на височина са от 0,5 до над 10 m. Образуванията са вулкански туфи с риолитов състав, чиято възраст е около 35 млн. години. През олигоцена днешните Източни Родопи са били дъно на море. В резултат на чести вулкански взривове, на морското дъно се образували дебели пластове вулканска пепел, примесена с различни късове от разрушаващите се по брега скали. Утайките се уплътнявали бавно и се превръщали в пластове от туфи, в които сега е оформена “Каменната сватба”. От съдържанието на различни минерали в тях  скалите се обагрили в различни цветове – бял, жълт, розов, зелен, ръждивочервен. Сред тях има прослойки и от други скали – варовици, конгломерати и др. Различният минерален състав на скалите определя тяхната различна здравина, а това е важно условие за моделирането на фантастичните фигури на пирамидите. Има ограничено значение от гледна точка на опазването на биологичното разнообразие. Посещението й не представлява никаква трудност през всички сезони. Народната фантазия е оприличила тази прекрасна природна композиция като сватбено шествие и го е свързала във вълнуваща легенда, в която доброто побеждава злото.", "https://sunrisinglife.com/wp-content/uploads/2019/04/DJI_0279.jpg", "Каменната сватба" },
                    { new Guid("32de8226-24d7-4085-9e1d-d9f5850f543c"), new Guid("e28de390-7ad8-433d-b84b-2229791c65f0"), "В парк „Тюлбето” в Казанлък се намира оригиналът на тракийска гробница от ІV-ІІІ в. пр. Хр., известна като Казанлъшката гробница. Тя има специален режим на съхранение. До нея е направено копие в мащаб 1:1, което показва архитектурата, археологическите материали и стенописите на Казанлъшката гробница, която е един от най-значителните паметници на тракийската култура в българските земи, включен в листата на световното културно наследство на ЮНЕСКО през 1979 г. Гробницата е откри­та случайно през 1944 г. в североизточния край на Казанлък и е забележителен паметник на тракийското изкуство от ранноелинистичната епоха. По своя архитектурен план тя принадлежи към куполните гробници, характерни за гробната архитектура на Тракия от края на V до началото на III в. пр. н. е. Разположена е в южната част на надгробна могила и се състои от три помещения: правоъгълно преддверие, тесен тухлен коридор (дромос) и тухлена гробна камера с кръгъл план и камбановиден купол. В гробницата са били извършени две погребения - на мъж и на жена, чрез трупополагане, което личи от запазените кости. Според археолозите гробницата е била ограбена още в древността. В могилния насип са намерени два глинени аскоса (плосък кръгъл съд с две дръжки) и сребърна каничка. В преддверието са разкрити глинен съд - ойнохое (кана за вино) и кости на кон. В куполното помещение са намерени остродънна амфора, глинени розети със суха позлата, погребален венец, дребни части от златни накити и фрагменти от местна тракийска керамика. Световната си известност паметникът дъл­жи на забележителните стенописи в коридора и куполното помещение - едни от най-добре запазените произведения на античната живопис от ранноелинистическата епоха. Неизвестният майстор е работил в четири основни цвята: черен, червен, жълт и бял. Стенната декорация имитира цветово лицевата стена на богата постройка, облицована с мраморни плочи и завършваща с архитектурни детайли. Представените воини върху втория фриз на коридора възпроизвеждат среща на две неприятелски войски, като на западната стена е изобразена сцена на борба. Сцените отразяват историческо събитие, свързано с живота на погребания в гробницата знатен тракийски владетел. В куполното помещение в центъра на главния фриз, срещу входа, са изобразени фигурите на мъж и жена, седнали край масичка, отрупана с плодове, а около тях са представени техните прислужници, носе­щи дарове. Изобразена е сцена на „погребално угощение с шествие\". Знатната съпружеска двойка е увенчана с лаврови венци - белег на героизиране, широко разпространено през елинистичната епоха. Стенната декорация в горния край на купола завършва с втори малък фриз, на който са представени три колесници, теглени от по два коня.", "https://img.vila.bg/a/83/1507.jpg", "Тракойската гробница" },
                    { new Guid("358770b8-c00d-48d8-b8a8-a1c7b687743a"), new Guid("3efe9a18-62e8-4ede-b3ef-a411e6136862"), "В продължение на повече от две столетия Търновград е столица на Второто българско царство (края на XII – XIV в.). Той е центърът, в който се решават най-важните политически, религиозни, административни и културни въпроси в живота на средновековната държава. Градът Търново територията на която е населявана от дълбока древност, се превръща в столичен център след възстановяването на българската държава през 1186 г. Столицата се разпростира върху укрепените с мощни крепостни стени хълмове Царевец, Трапезица, Момина крепост, склоновете към естествената водна преграда р. Янтра и надзаливните и тераси. Господстващото положение на хълма Царевец и естествената му непристъпност са предопределили избора тук да бъде центърът на върховно управление на държавата. Сложна укрепителната система е осигурявала безопасността на живеещите в крепостта. Главният вход към вътрешността е от запад. Защитен е от четири последователно разположени порти и кули над тях. Пред първата порта е имало подвижен дървен мост. В близост до най-вътрешната порта са разположени казармените постройки на охраната. Доминиращо място в крепостта заемат дворцовия и патриаршеския комплекс. Дворецът на българските царе е защитен от всички страни с мощна крепостна стена и кули. Във вътрешността му са разположени сгради с богато украсени фасади.Ограденият с крепостна стена и кули патриаршески комплекс заема площ от 2413 кв. м. В него са се намирали библиотеката, скрипоторият, жилищните и служебни помещения на патриарха, килиите на монасите. Патриаршеския храм “Възнесение-Господне” с кула-камбанария е разположен в средата на вътрешния двор.", "https://balkannomad.com/wp-content/uploads/2019/11/shutterstock_748620841-scaled.jpg", "Царевец" },
                    { new Guid("406ec1ac-fdb9-42ac-8ddd-5cb4b06282a0"), new Guid("bad041da-8d53-474a-97de-8693510f64ae"), "„Баба Вида“ е единственият изцяло запазен средновековен замък в България, играл едновременно роля на отбранително съоръжение и на владетелски замък. Издига се на брега на Дунав, в североизточната част на Видин. „Баба Вида“ е единственият изцяло запазен средновековен замък в България, играл едновременно роля на отбранително съоръжение и на владетелски замък. Издига се на брега на Дунав, в североизточната част на Видин. Почти през целия период на Второто българско царство Видинската крепост е най-важното укрепление в Северозападна България. Най-голямото й разширение е по време на управлението на цар Иван Срацимир, управлявал Видинското царство. Той обитава мястото като феодален замък. Срацимировата кула е строена през XIII-XIV век и е най-добре съхранената част от времето на средновековния български период. Висока е 16 метра, по стените й са запазени доста тухлени орнаменти – розетки и паници. Смята се е, че един от тях представлява надпис „Шишман“ – предположението е изказано от Иван Велков през 50-те години на ХХ век. Близо до тази кула е тайният изход на замъка.", "https://bookvila.bg/img/210214030202.jpg", "Крепост Баба Вида" },
                    { new Guid("4a9a7f60-babf-4582-b851-88bcba1bc831"), new Guid("7a65d489-304c-4be8-b344-7d53a644e080"), "Комплексът е официално открит през 2013 година, като северната, южната и източната стена са обновени, а църквата е изцяло реставрирана. В превод името Цари Мали град означава „Малкият Цариград“. Официално обявена за паметник на културата с национално значение, според историците това антично бижу е имало два периода на изграждане. Първият е бил този на траките от VIII до VI век пр. Хр., а вторият на римляните по времето на Юстиниан Велики и Юстин III. Мястото, на което е изградена крепостта, е стратегическо и със сигурност не е избрано случайно. Тя се намира върху хълм Свети Спас, а в близост до нея преминава важният кръстопът, който свързва Константинопол и Рим. Ключов елемент за нейното местоположение са и намиращите се наблизо минерални извори. През множеството векове, в които е съществувал, Цари Мали град е бил многократно разрушаван от различни племена, а след силно земетресение е сринат до основи. По време на своите разкопки, археолозите са разкрили останки от три храма, множеството ями и керамични фрагменти, както и други интересни артефакти.", "https://imgrabo.com/pics/guide/900x600/20170629110550_10052.jpeg", "Цари Мали град" },
                    { new Guid("4dba5e4a-a838-4568-a7b8-fa824f5c6dd2"), new Guid("283a59a6-77c5-4b38-a579-05086cd4c375"), "Панорамата „Плевенска епопея 1877 г.” е построена в чест на 100-годишнината от Освобождението на Плевен от османско иго. В първите 3 години след нейното откриване, е посетена от 2,5 милиона души. Тя е сред почти 200-те паметници, построени от плевенчани в памет на загиналите руснаци, румънци и българи. Включена е в Стоте национални туристически обекта. Изградена е в района на Скобелевия парк, непосредствено до редута „Кованлък”, където по време на 3-та атака от обсадата на Плевен се водят едни от най-тежките сражения. Автори на проекта са архитектите Иво Петров и Пламена Цачева, заедно с проектантски екип от 14 души. Автор на живописната част и главен изпълнител е Николай Овечкин (Военно студио „М. Греков”, Москва). Колективът е от 13 руски и български художници: В. Щербаков, И. Кабанов, А. Чернишов, М. Ананиев, Н. Овечкин, Д. Дончев, В. Есаулов, В. Лемешев, Хр. Бояджиев, Г. Есаулов, В. Таутиев, Ю. Усипенко и А. Троценко. Архитектурното тяло на Панорамата е направено да изглежда повдигнато върху 4 щика, които олицетворяват силата на оръжието, донесло свободата. Щиковете носят 4 хоризонтално разположени пръстена, 3 от които символизират 3-те атаки срещу Плевен, а 4-ят пръстен е декоративно-пластичен фриз, символизиращ обсадата на Плевен. Туристите могат да се изкачат на 2 зрителни площадки на покрива на музея, откъдето могат да наблюдават историческите места: Мъртвата долина, редутите „Кованлък” и „Исса ага”, Костницата в Скобелевия парк, Радишевските и Гривишките възвишения.", "https://upload.wikimedia.org/wikipedia/commons/1/19/Panoramata.jpg", "Панорама \"Плевненска епопея\"" },
                    { new Guid("4e46992e-af3f-49d9-b39e-f80911a79c5b"), new Guid("a51a3b6b-59e9-4b38-814f-a90483b12a71"), "Чудните мостове са скален феномен, известен в миналото с турското име Еркюприя, което означава скален, земен мост. Разположен е в карстовата долина на река Еркюприя в Западните Родопи, на 1450 м надморска височина, в подножието на връх Голям Персенк (2091 м). Скалният феномен се намира на 80 км южно от Пловдив, на 35 км северозападно от Чепеларе и само на 5 км северозападно от село Забърдо. В миналото мостовете са представлявали една пещера, образувала се под рушащото действие на речните води. С течение на времето части от нея се срутили, образувайки величествените мраморни мостове. Големият мост е широк около 15 м в по-широките части и дълъг почти 100 м. Състои се от три арки, като най-голямата е с височина 45 м и ширина 40 м. Малкият мост е на 200 м от големия по течението на реката - непроходим, дълъг 60 м, с обща височина 50 м, а височината на арката е 30 м. След него има и съвсем малък трети мост, който представлява понорна пещера, в която водите на р. Еркюприя изчезват, за да се появят пак на повърхността след 3 км. Легенда разказва за създаването на Чудните мостове. Преди много години в землището на село Забърдо имало много пастири. Незнайно от къде се появил змей, който започнал да опустошава стадата им. Дълги години пастирите страдали от набезите на змея. Накрая те измислили как да го надхитрят. Натоварили едно магаре с прахан (сухо вещество от дървесна гъба, което служи за запалване на огън от огниво), запалили го и го изпратили срещу змея. Змеят глътнал магарето заедно с праханта, която бавно, но сигурно се разгаряла. Обезумелият змей отчаяно се опитвал да избяга, накрая намерил малка дупка в земята. Огромното му тяло отворило пролуката. След години, когато костите на змея изгнили, останали огромните сводести мостове. Така според легендата се появявили Чудните мостове.", "https://i2.wp.com/time2travel.bg/wp-content/uploads/2015/10/1445171754_DSC0862-min-e1445191200261.jpg?fit=1000%2C664&ssl=1", "Чудните мостове" },
                    { new Guid("4e98fee8-307b-43e0-98a0-09378884720c"), new Guid("5bc79020-4a92-43fb-9c97-7550bdc8f6c9"), "Поемем ли на запад от Варна, магистралата ни отвежда до геоложкия феномен Побити камъни. Кой би предположил, че току извън големия град е скътано местенце, където може да намалим стреса до минимум и да се полюбуваме на уникалните образувания, възникнали преди около 50 милиона години на дъното на някогашно море. Всред пясъци, които днес по-скоро създават усещането за пустиня, може да се види удивителна сбирка от стотици каменни колони, извисяващи се гордо на височина до 5-6 м. Дебелината им е от 0,50 до 2,50 м, а повечето крият в себе си различна по големина кухина. Макар причините за възникването на тази каменна гора да са изгубени далеч назад във времето, учените имат редица хипотези за образуването ѝ. Единственото нещо, създадено от човека, е окръжност, която показва мястото с най-силен енергиен заряд. Ако може да се вярва на мълвата, пожелаем ли си нещо тук, то непременно ще се сбъдне. Местността Побити камъни, известна някога като Дикилиташ, обхваща площ от около 50 кв.км, пасторално разположена между землищата на гр. Белослав и селата Слънчево, Страшимирово и Баново. По цялата територия има колони - на места са разхвърляни само по няколко, а другаде се извисяват стотици каменни колоси. Най-многобройна и посещаваната е Централната група, поради което често е отъждествявана с името на цялата местност. През лятото често няма ни едно облаче, което да укроти палещото слънце, обливащо този почти сюрреалистичен пейзаж, но това не плаши стичащите се на талази туристи. А после, вълната от хора, придошла с настъпването на деня, се оттегля бавно към града и щом тълпите оредеят, мястото отново бива обзето от мистично безвремие.", "https://varnacitycard.com/wp-content/uploads/2019/01/varna-stone-forest-1-1.jpg", "Побитите камъни" },
                    { new Guid("541d17af-b104-479e-babd-f2efeee7eed1"), new Guid("444c2d73-bb42-4f55-83d3-8930a7257f2e"), "Кончето е популярна и сравнително труднодостъпна седловина в Северен Пирин, намираща се на главното планинско било между върховете Бански суходол и Кутело, на около 2810 м н.в.. Представлява скален ръб със почти отвесни североизточни и много стръмни северозападни склонове, в най-тясната си част широка до половин метър. Дължината на ръба е около 400 м. За първи път при зимни условия седловината е била премината от Любен Телчаров и Никола Миронски през месец март 1934 година. Разказа на Любен Телчаров за това преживяване можете да откриете в мартенския брой на списание Български турист от същата 1934 година. През 1963 година, за да бъде улеснен прехода през седловината, по ръба е поставен метален парапет. През 1969 година е прокарана подсичащата пътека по югозападните склонове на Кончето, също осигурена от метално въже, което преди няколко години беше удължено в посока към Премката (седловината между Вихрен и Кутело).", "https://tripsjournal.com/wp-content/uploads/2017/10/47-sedlovina-koncheto-kym-banski-suhodol.jpg", "Кончето" },
                    { new Guid("5c42fbc4-ba34-4a50-b4a9-ed937312a87c"), new Guid("ed910cd8-575a-4329-a93c-ef5a14cc956d"), "Пещерата “Леденика” се намира в Северозападния край на Врачанската планина, на 16 км. от гр. Враца. Пещерата впечатлява с големите си размери, а през зимата грабва посетителите с изящната си ледена украса, откъдето произлиза и името й. През пролетта и зимата първата зала на пещерата – Предверието - очарова с ледено кристалната си украса. Най-високата точка на пещерата се нарича “Седмото небе” и е достъпно само за най-запалените туристи. Температурата в пещерата варира от –7 до –15 градуса до 8 градуса във вътрешността. Влажността на въздуха е 92%. За да видите пещерата \"Леденика\" в цялото й великолепие, е най-добре да я посетите през зимата или пролетта. Тя се намира в северозападната част на Врачанската планина и е на 16 километра от града. Известна е на хората от този край отдавна, даже в нея овчарите са съхранявали млякото на хладно. Входът й е на 830 надморска височина, в най-ниската част на Леденишкия валог. През зимата студеният въздух нахлува в пещерата през няколко понора и изстудява три от най-интересните зали - Преддверието, Малката и Концертната зала. По стените им се образува скреж и цели ледени водопади, от таваните увисват феерични висулки, напомнящи боздугани и мечове, на подовете се появяват „сервизи от бутилки и чаши\", сътворени от вездесъщия лед, а до самия вход, в Преддверието, се възправя огромна ледена колона. Вече разбирате защо тази пещера не е могла да бъде наречена другояче освен Леденика.", "https://www.nadezhdatravel.com/wp-content/uploads/2017/10/800px-Saeva_dupka-800x510-1.jpg", "Пещерата Леденика" },
                    { new Guid("5e05d493-1a23-4943-8076-2e33a92054a0"), new Guid("833246ee-f3be-4337-b84a-a0cc58f22558"), "С право е наричана една от най-красивите пещери. Снежнобелият цвят на дребнозърнестите мрамори, които е прорязала Новомахленска река преди повече от 3,5 милиона години, за да създаде това природно чудо, я прави неповторима. Оттам идва и името на пещерата, защото в така наречената Вълшебна зала, сред изящните синтрови образувания и езера, очарованото око с лекота различава фигурата на Снежанка, балдахина на нейното легло и други детайли от любимата приказка, сътворени сякаш от феерична снежнобяла материя. В пещерата могат да се видят едни от най-красивите карстови форми в България. Безспорно подобряват настроението табелите с надписи като: \"По-бавно\", \"Не се предавай\", \"Спри и си почини\"... Няколко са предположенията за името и на близкия град Пещера, но надделява становището, че причина за това наименование най-вероятно са пещерите Снежанка и Юбилейна. Находките, открити там, дават основание на изследователите да заключат, че през бронзовата епоха те са били обитаеми и, че възникването на селище в Пещерската котловина, е станало някъде през втората половина на IV век преди Христа. Много свидетелства са останали от времето, когато са се смесвали трите етноса -траки, славяни и българи: не само мостове, останки от пътища и крепости, но и саркофази, култови предмети, оръдия на труда, накити и оръжия.", "https://imgrabo.com/pics/guide/900x600/20160121172215_29419.jpeg", "Пещерата Снежанка" },
                    { new Guid("668a926d-4b4c-4c4c-9b0d-a818900b03e1"), new Guid("6ba29df6-f14e-4096-a055-352aef819261"), "Изследователи определят \"Глухите камъни\" като най-големия тракийски скален култово-погребален комплекс. Името \"Глухите камъни\" вероятно е породено от липсата на ехо в местността. Религиозното светилище се намира в източното подножие на връх \"Света Марина\", на границата между землището на с. Ефрем (на около 3,5 км от селото) и с. Малко Градище (около 4,8 км от него според доц. Нехризов). От върха на скалата се открива широка панорама към долините на Марица и Арда. При хубаво и ясно време могат да се видят и минаретата на Одрин. Най-интересното откритие през 2008 г. от екипа на д-р Нехризов от Археологическия институт на БАН е уникалният тракийски петроглиф – рисунка, изсечена в скалата. По думите на д-р Нехризов: \"Изобразена е ладия, която пренася слънцето.\" Според него това е емблемата на целия комплекс. Петроглифът е врязан на пода на естествено оформена плитка пещера, разположена на западната страна на най-високата западна скала. През 2011 г. комплексът \"Глухите камъни\" получи статут на археологическа недвижима ценност с национално значение.", "https://drumivdumi.com/wp-content/uploads/2016/06/0gluhite_kamyni_3997.jpg", "Глухите камъни" },
                    { new Guid("6dfef1a3-d8f2-44d8-87b7-1f272b79de47"), new Guid("48a438e7-5d75-4a51-8076-de210c7f6323"), "Регионален етнографски музей на открито „Етър“ е музей на открито, разположен в кв. Етъра в Габрово. Представлява възстановка на българския бит, култура и занаятчийство. Той е първият по рода си музей в България. Открит е на 7 септември 1964 г. Музеят е разположен на 8 км южно от основната част на Габрово. В РЕМО „Етър“ се намира единствената в България сбирка на народна техника на вода. Тя съдържа 10 експоната и е една от богатите и добре организирани технически сбирки сред европейските музеи на открито. Това е причината, водното колело да се превърне в една от емблемите на музей „Етър“. Най-важната особеност на сбирката е, че всички обекти са в действие, така както в миналото. Занаятчийска чаршия представя 16 образци на балканската архитектура, разкриващи самобитния талант на възрожденските строители. Част е от Стоте национални туристически обекта.", "https://kristinalikova.com/wp-content/uploads/2022/03/MG_1472-copy.jpg", "Етъра" },
                    { new Guid("6e3e0f5d-4220-4588-88c4-ec55a50e9271"), new Guid("a51a3b6b-59e9-4b38-814f-a90483b12a71"), "Дяволското гърло е пропастна пещера, която привлича туристите с тайнствената си красота, ревящата стихия на подземния водопад (най-високия на Балканите), образуван от падащите в 42 м. пропаст води на река Триградска, както и с множеството легенди, които разпалват въображението. Пещерата е част от уникалния карст на Триградското ждрело, намира се на 1,8 км северно от село Триград и на 17 км южно от град Девин. Наречена е Дяволското гърло, защото както разказват местните хора – нищо, попаднало в подземния лабиринт на пещерата, не излиза от там. Според легендите, именно през Дяволското гърло Орфей проникнал в подземното царство на Хадес, за да спаси своята любима Евридика. Любовта му затрогнала Хадес и той им разрешил да излязат от подземното царство, при условие, че Орфей не се обръща назад. Но минавайки през бучащата зала, той вече не чувал стъпките на Евридика, уплашил се и се обърнал. Тялото на Евридика се вкаменило, а душата ѝ се върнала в подземното царство. В пещерата се влиза само с екскурзовод, тя е част от 100-те национални туристически обекта. Туристическият маршрут започва от специална галерия, водеща към огромната зала с водопада, която е наречена Бучаща зала, поради оглушителния рев на падащата вода. Удивителното е, че туристите могат да слязат покрай водопада по специално изградени стъпала, обезопасени с предпазни парапети, и да наблюдават буйния кипеж на водата. Друг интересен факт е, че  след около 400 м от входа на Дяволското гърло, водите на река Триградска изведнъж изчезват – попадат в сифон с дължина около 150 м, а след него по нова галерия подземната река напуска пещерата, преминава през друга пещера и се появява на повърхността.", "https://preotkrii.bg/wp-content/uploads/2022/10/241844214_10220024801751299_6093133946531686972_n.jpg", "Дяволското гърло" },
                    { new Guid("72876cec-f198-4a21-87c0-fb5c2a6dd245"), new Guid("5bc79020-4a92-43fb-9c97-7550bdc8f6c9"), "Феста Делфинариум е единствено по рода си в България атракционно съоръжение. Разположен е сред зеленината в северната част на варненската Морска градина, с чудесен изглед към морето. Открит е на 19.08.1984 г. и е един от символите не само на Варна, а и на българския туризъм. Делфинариумът е неотменна точка в програмите на всички туристи, посещаващи Черноморието. Сградата впечатлява с футуристичната си конструкция и фасада от алуминий и стъкло. Делфинариумът е проектиран от колектив, под ръководството на известния архитект Симеон Саралиев. Самата постройка представлява лека пространствена конструкция във формата на стъклен куб, с размери 30 х 30 метра и височина 14 метра. Интересна подробност е, че изкопните работи по инсталационния етаж и самите басейни са се извършили след монтирането на носещата покривна конструкция. Първите делфини са пристигнали във варненския делфинариум през 1984 г. от кубински делфинариум. Те са от вида Tursiops truncatus (бутилконоси делфини). В световен мащаб винаги се е считало, че ражданията на делфини в изкуствена среда са рядкост. Благодарение на създадените отлични условия и професионални грижи, полагани от екипа на Феста Делфинариум, тук ражданията са нормална практика. В момента се отглеждат 5 делфина - Кимбо, Доли, Флипър, Йоана и Бимбо.", "https://rezervaciq.com/img/objects/sights_606_1303122997%D0%94%D0%B5%D0%BB%D1%84%D0%B8%D0%BD%D0%B0%D1%80%D0%B8%D1%83%D0%BC_%D0%92%D0%B0%D1%80%D0%BD%D0%B0.jpg", "Делфинариумът във Варна" },
                    { new Guid("786fbb67-da62-4235-8d96-9bc2d47005ff"), new Guid("a6094c67-3d3b-4f06-9bdf-320df7e8e236"), "Историко-археологически резерват Мадара е създаден през 1958 г. и в неговите граници се намират обекти от различни епохи с изключително значение за българското културно наследство. Сред тях са включения в списъка на ЮНЕСКО като паметник със световно значение Мадарски конник, Мадарската крепост, римска вила, старобългарска баня, две пещери, като за едната има сведения, че е ползвана като тракийско светилище през 4 - 3 век пр. н.е., скален манастир и други. Мадарският конник представлява уникален скален релеф датиращ от началото на 8 век. Релефът е изсечен върху стометрова, почти отвесна варовикова скала и е единственият подобен релеф на територията на цяла Европа, без паралел в европейското културно наследство. Грижливо изработената композицията на релефа представя ловна сцена, в която в естествени размери е изобразени конник в ход надясно, който пробожда с копие поваления в предните крака на коня лъв. Пред конника има летящ орел в хералдична поза, а зад него - изображение на куче. Около тази сцена има надписи на гръцки език разказващи за важни моменти от историята на българската държава. Първият надпис е от времето на хан Тервел (701 - 717) и разказва за помощта, която ханът оказва на император Юстиниан II да си възвърне престола в Константинопол. Вторият надпис се намира вляво под конника и е от времето на хан Кормисош (ок. 756). Отнася се за българо-византийските отношенията и за данъка, който по това време Византия изплаща на България. Третият надпис, разположен долу вдясно, е от времето на хан Омуртаг (814 - 831) и отново се отнася за отношенията между България и Византия. Тези надписи са първите, най-ранни домашни писмени извори за българската история. Съществуват тези, че конникът, изобразен на Мадарския барелеф, вероятно е някой от българските владетели - Аспарух, Тервел или Крум. Въпреки че споровете по въпроса не са приключили, наложило се е мнението, че конникът изобразява български владетел, а прободеният и победен лъв символизира Византия. През 1979 година Мадарският конник е включен в списъка на световното културно наследство на UNESCO.", "https://bulgarianhistory.org/wp-content/uploads/2017/07/madarski-konnik-%D1%86%D0%BE%D0%BF%D1%8A.jpg", "Мадарският конник" },
                    { new Guid("803b5da6-d751-4da9-9059-b5f5a4089656"), new Guid("006902e5-3b36-42da-a288-77a33f44f021"), "Седемте Рилски езера са група езера с ледников произход, намиращи се в планината Рила. Надморската им височина варира от 2095 м до 2535 м. Това е най-посещаваната от туристи езерна група в България, част от Стоте национални туристически обекта. Те са разположени стъпаловидно като отделните езера са свързани помежду си чрез малки поточета. При преминаването на водата по тези поточета се образуват малки водоскоци и водопади. От горе надолу езерата носят следните имена: Сълзата, Окото, Бъбрека, Близнака, Трилистника, Рибното и Седмото езеро. Името на всяко от Седемте рилски езера има връзка със специфични външни особености на даденото езеро. Сълзата е на височина 2535 м. Носи името си заради прозрачността на водите, които предлагат видимост в дълбочина. Езерото е малко като размер - има площ 7 декара и едва 4.5 м. дълбочина. Следващо по височина на разположение е Окото, което е с почти идеална овална форма. Окото е най-дълбокото циркусно езеро в България - дълбоко е 37,5 м. Площта му е 68 декара, а надморската му височина - 2440 м. Езерото Бъбрека има характерна форма (изглежда точно като бъбрек), разположено е на 2282 м. надморска височина, а най-голямата му дълбочина е 28 м. То е езерото с най-стръмните и скалисти брегове от цялата група. Езерото Близнак е разположено на 2243 м. надморска височина, има площ от 91 декара и дълбочина до 27 м. Това е най-голямото по площ езеро от Седемте рилски езера. Към средата си езерото се стеснява и през безводни години почти се разделя на две по-малки езера, откъдето произхожда и името му. Понякога е зарибявано с планинска пастърва. Трилистниковото езеро е на височина 2216 м. и е с неправилна форма. На места бреговите му очертания се губят в разлети потоци; площта му е 26 декара, а максималната дълбочина - 6.5 м. Рибното езеро е разположено на височина 2184 м. и е най-плиткото - дълбочината му достига едва 2.5 м. Площта на това езеро е 35 декара. Бреговете му са тревисти, а дъното тинесто, обрасло с тръстика. Седмото (Долно) езеро е на височина 2095 м. То е най-ниското от седемте езера. Събира водите на всички останали езера о дава началто на река Джерман. Площта му е 59 декара, а дълбочината му - 11 м. Характеризира се с ниски и затревени брегове", "https://static.dir.bg/uploads/images/2022/07/11/2379217/1366x768.jpg?_=1657527245", "Седемте рилски езера" },
                    { new Guid("811a6466-60f5-44ff-ac3e-6130b08ac648"), new Guid("bad041da-8d53-474a-97de-8693510f64ae"), "Пещерата се намира в северозападна България, на 17 км. от гр. Белоградчик. Издълбана е във варовиковата Рабишка могила (461 м. надморска височина). Една от най-големите пещери в страната-обща дължина на откритите досега галерии е около 2500 м. Състои се от главна галерия и три странични разклонения. Според геоложки проучвания образуването на пещерата Магура е започнало преди около 15 млн. години. В една от залите са разкрити праисторически рисунки, издълбани в скалата и изрисувани с прилепно гуано (тор). Фигурите изобразяват танцуващи женски силуети, танцуващи и ловуващи мъже, маскирани хора, животни, звезди, оръдия на труда, растения. Рисунките датират от различни епохи - епипалеолит, неолит, енеолит, начало на раннобронзовата епоха. Слънчевият годишен календар от късния неолит, открит там, е най-ранният слънчев календар, открит досега в Европа. Той е изрисуван по стените на залата светилище и на него са отбелязани поне 5 празника, както и 366 дни. Пещерата притежава едни от най-богатите по форма и размери образувания - сталактити, сталагмити, сталактони, синтрови джобчета, пещерни бисери, „пещерно мляко”. С внушителни размери впечатлява „Големият сталактон” с височина над 20 м и диаметър на основата 4 м. „Падналият бор” пък е най-големият сталагмит в изследваните български пещери с дължина над 11 м и диаметър в основата 6 м.", "https://www.bestbgtrips.com/sites/default/files/imageor/28/magurata5.jpg", "Пещерата Магурата" },
                    { new Guid("867bc69f-baae-4481-931a-ba5cc8e9fd1a"), new Guid("a6094c67-3d3b-4f06-9bdf-320df7e8e236"), "На около 29 км от Шумен и само на 2 км от съвременния град Плиска се намират останките от първата българска столица. Плиска е столица на Първата българска държава в периода от 681 до 893 г. Националният историко-археологически резерват „Плиска” е обявен за археологически паметник на културата с национално значение с брой 46 на Държавен вестник от 1970 г. Мястото, на което е изградена столицата, не е било избрано случайно - разположено в равнина и заобиколено от склонове на съседните плата, прабългарите избрали това място поради благоприятните условия за скотовъдството. Освен това в района на Плиска се пресичали важни пътища. В края на VІІ в. и началото на VІІІ в. започват първите строежи в Плиска. Те били от дървени сгради с кръгла или четириъгълна форма, някои от тях били жилищни постройки, а други служили за представителни нужди. Първоначалният дворцов комплекс на Плиска бил ограден с крепостна стена, а в полето около нея възникнали селищата на обикновеното население. Към края на VІІІ в. и в началото на ІХ в. дървените постройки били заменени с каменни. Счита се, че най-напред е била изградена голямата каменна сграда - Крумовият дворец. През 811 г. византийският император Никифор опожарил столицата. Преустройството на дворцовия център било завършено през царуването на Омуртаг (814–831). Нова тронна зала била изградена на мястото на опожарения Крумов дворец, дворцовият център бил ограден с каменна стена, а жилищните и стопанските сгради - с висока тухлена стена. Приемането на християнството през 864 г. при княз Борис І (управлявал 852 – 889 г.) променя и столицата Плиска - езическите храмове са преустроени в християнски, строят се нови храмове, измежду които най-внушителна е Голямата базилика, от която могат да се видят останки и до днес. През 889 г. княз Борис се оттеглил в манастир, предавайки управлението на първородния си син Владимир (Расате). Той обаче опитал да възстанови старата езическа вяра и заради това бил хвърлен в тъмница и ослепен. През 893 г. било решено престола да заеме Симеон І (управлявал 893 – 927 г.), а столицата да бъде преместена от Плиска в Преслав.", "https://xn----7sbb3acmfmvip.bg/wp-content/uploads/2017/10/Pliska-bazilika-1024x496.jpg", "Плиска" },
                    { new Guid("a4ef6341-8fd5-489e-8a29-878a4243c170"), new Guid("76500059-135a-425f-8aa3-f9b1110cecdf"), "Крушунските водопади, несъмнено, са едно от най-красивите и интересни места за посещение и туризъм в България. При това, до тях се стига доста мързеливо – с кола. В допълнение, човек може да ги обходи по сравнително кратка екопътека, без много усилия. Всичко това ги прави и една от най-посещаваните природни забележителности у нас в последните години. Крушунските водопади са най-голямата в страната водна травертинова каскада. Те са няколко, като най-високият се спуска от 15 метра височина. Намират се до ловешкото село Крушуна, в карстовата местност Маарата на северния склон на Деветашкото плато в средния Предбалкан. Реката, която ги захранва се нарича Пройновска, а също и Маарата, по името на пещерата, от която извира. Районът на село Крушуна е известен с една от най-късите екопътеки в България и една от най-дългите пещери – Бонинската пещера. Който е ходил там преди десетина години, когато каскадата не беше все още толкова популярна, вероятно ще се изненада, ако отиде сега, от развитието на района – заведения, къщи за гости, голям плувен басейн … Водопадите „работят“ през цялата година и разходката покрай тях почти винаги носи свежест и приятно изживяване, а и лек мирис на скара в някои части на парка.", "https://drumivdumi.com/wp-content/uploads/2017/03/0krushunski_vodopadi_7090.jpg", "Крушунските водопади" },
                    { new Guid("a8b7a480-6594-4051-867a-f9fcfcf071d4"), new Guid("1e72e4f6-588e-42e6-b93b-9122458547d5"), "Средновековната пернишка крепост е разположена на неголямо скалисто плато в югозападната част на Перник. Запазените останки очертават многоъгълна крепост, за която се смята, че е построена по времето на хан Омуртаг. Археолозите откриват останки, които показват, че крепост на това място е съществувала още през VІ – V в. пр. н. е. Крепостната стена е с дебелина 2 метра. Очертанията й следват естествените извивки на платото. Тази тракийска крепост е една от най-значимите в българските земи, засвидетелствана по археологически път. В началото на ХІ век владетел на крепостта и селището Перник е боляринът от прабългарски род Кракра. Легендите и песните за непобедимия войвода Кракра се разказват и пеят до ден днешен. Пернишката крепост придобива международна известност, когато театърът на военните действия между България и Византия се преместил в западните български земи. Византийският хронист Скилица е описал борбата на българите, водени от управителя на Пернишката крепост – Кракра, срещу византийския император Василий ІІ. Крепостта издържала на яростните обсади през 1004 и 1016 г. От крепостта се открива изглед към местността “Кървавото”. Според легендата през 1016г. Кракра устоява на 88-дневна обсада, при която загиват много византийци. Оттук идва името на местността. Според едно от житията на закрилника на града – Свети Иван Рилски, в тази местност се е намирала пещерата на отшелника.", "https://museumpernik.com/wp-content/uploads/2022/11/7a-1.jpg", "Крепост Кракра" },
                    { new Guid("b1edc186-3e15-4817-8146-837678629bb8"), new Guid("76500059-135a-425f-8aa3-f9b1110cecdf"), "Съвременните проучвания на Деветашката пещера започват през 20-те години на миналия век. Открити са доказателства, че пещерата е била населявана през почти всички праисторически епохи. Откритите оръдия на труда, керамични съдове и накити се съхраняват в Регионалния исторически музей в Ловеч, а някои от тях и в Националния исторически музей в София. От 1952г. пещерата е използвана за съхранение на горива от Министерство на отбраната. Монтирани са 15 огромни цистерни, пещерата е електрифицирана, а над река Осъм е изграден ж.п. мост. Достъпът на цивилни лица до обекта е забранен. През 90-те години на миналия век започва разчистването на пещерата – цистерните са изнесени, но част от постаментите им стоят и до днес. Ж.п. мостът е оставен да се руши дълго време. Достъпът до Деветашката пещера се осъществява пеша от разклона за село Деветаки и отнема около 20-30 мин. През 2011г. в пещерата се снимат сцени от филма Непобедимите 2. Това вдига на крак еколози и природозащитници, заради нарушаване на спокойствието на защитените видове, обитаващи пещерата. За целите на филмовата продукция е изграден мост над река Осъм, срещу входа на пещерата, който сега се използва от посетителите. Поради улеснения достъп, Деветашката пещера се посещава от много повече хора всяка година, което е предпоставка за налагането на ограничения с цел съхраняване на растителния и животински свят в нея.", "https://www.lovech.bg/uploads/posts/img_5624347-hdr_stitch.jpg", "Деветашката пещера" },
                    { new Guid("b4b8d00d-575a-4923-9e74-096b6ef14cf1"), new Guid("6ba29df6-f14e-4096-a055-352aef819261"), "Антична вила Армира се намира на около 5 км южно от хотелски комплекс “Луксор”. Вила Армира е датирана от I-III век сл.Хр. и е призната за най-богатия частен дворец от римско време по българските земи. Била е собственост на богат аристократ, който я построява в центъра на своето земевладение. В центъра на самата вила имало огромен басейн, живописно пълнещ се с водна струя, излизаща от красива мраморна фигура. Цялата вила е била декорирана с плочи и пана от искрящ бял мрамор, част от които може да разгледате и днес. Стените на коридорите и помещенията са били украсени с цветни стенописи. Уникален и единствен от времето на римската епоха у нас е портретът от мозайка в господарската спалня, изобразяващ собственика с двете му деца - реставриран като част от чудесата на вила Армира. Вила Армира е изцяло реставрирана и отворена за посещения.", "https://upload.wikimedia.org/wikipedia/commons/e/e7/Villa_Armira%2C_the_Mosaics_2.jpg", "Вила Армира" },
                    { new Guid("b9d16409-6cab-4a1c-9860-8e11ab6bd8dc"), new Guid("8ac44425-1406-47e4-b8b1-4349f8417d9e"), "Природен парк Сините камъни, намиращ се северно от гр. Сливен, е част от планинската верига Стара планина. Голяма част от неговата територия представлява причудливи и интересни скални образувания, подходящи за преходи, алтернативен и орнитологичен /наблюдение на интересни видове птици/ туризъм. В Природния парк има маркирани маршрути, които обхождат голяма част от територията му. От гр. Сливен до м. Карандила има изградена открита въжена линия, която предлага възможност за пътуване с пейзажна фотосесия. Природният парк е с голямо биологично разнообразие, което предоставя алтернативи за различни видове научни, образователни и туристически обходи. На територията на парка има изградени информационни центрове и фото-укрития за сесии на различни интересни хищни птици – белоглав лешояд, скален орел, гарвани и др. Интересни реки в парка са – Давидова, Магарешка, Селишка, Новоселска, Асеновска, Джендем дере и др. Проучванията върху най-старата история по неоспорим начин доказват, че на територията на парка е имало заселници още през новокаменната епоха. На десетки места по Сините камъни могат да се видят руини от стари крепости, манастири, аязми, древни пътища. В м. Хисарлъка се намира археологическият резерват „Туида“ – римска крепост от ІІІ – V век, а по поречието на р. Манастирска има останки от един от 24 – те манастири, строени през ХІІІ – ХІV век, известни като Сливенската малка Света гора. Съчетанието между релефа, водните течения, богатата флора и фауна, интересните скални образувания и разкриващата се панорама представлява взаимно свързано, взаимообусловено единство, предаващо специфичен облик – силно подчертан и характеризиращ една интересна среда.", "https://faiton.bg/wp-content/uploads/2023/08/sinite-kamani-sliven.jpg", "Сините камъни" },
                    { new Guid("c259e2f1-e421-493d-8a83-2bff1f4d6a3e"), new Guid("47181a59-c6c1-42ff-8304-10b56c9f59fe"), "Дворецът и Ботаническата градина в Балчик, обединени в архитектурно-парков комплекс, са късче земен рай и задължителен за посещение туристически обект по Българското Черноморие. Намират се на около 50км северно от гр. Варна. Комплексът възниква като лятна резиденция на румънската кралица Мария (1875–1938г.), която се влюбва от пръв поглед в малкото късче българска земя на брега на Черно море. Дворецът е дело на италиански архитекти, а началото на изграждането на резиденцията започва през 1924 г. и завършва през 1936 г. Изградени са параклиси, дворове, паркове, чешми и сгради в различни стилове – старобългарски, византийски, римско-арабски, мавритански, трансилвански и др. Този еклектичен стил се дължи на румънската кралица – последовател на бахайската религия, която изповядва съществуването на един Бог и единството на цялото човечество. Като част от резиденцията, през 1926г. швейцарският ботаник Жул Жани проектира и изгражда парков комплекс. 29 години по-късно Софийски университет „Св. Климент Охридски” създава на това място ботаническа градина с площ 65 дка. Градината е световноизвестна с уникалната си колекция от едроразмерни кактуси, която е втора по рода си в Европа след тази в Монако.  Интерес за специалисти и туристи представляват екзотичните видове като каучуково, бонбонено, книжно дърво, древно гинко, метасеквоя, едроцветна магнолия. Представени са едногодишни пролетни и летни цветя, алпийска и водна растителност, папрати, защитени и редки видове, лиани, цъфтящи и вечнозелени храсти. В тази неповторима градина се отглеждат над 3000 растителни вида от цял свят.", "https://experience.bg/image/data/destinacii/shabla/kumping-kosmos/experience-bg-balchik-botanicheska-1.jpg", "Ботаническата градина в Балчик" },
                    { new Guid("c9d62292-ef45-43d2-8599-e8561c911d49"), new Guid("5bc79020-4a92-43fb-9c97-7550bdc8f6c9"), "Провадийската крепост е построена на величественото плато източно от града, познато под името Калето. Тя се използва от средата на ІІІ до края на ХVІІ век, с прекъсване от първите десетилетия на VІІ до Х век. Византийците я назовават Проват, българите – Овеч, а турците – Таш хисар (каменна крепост). Уникалните природни дадености я правят трудно превземаема. Твърдината отвсякъде е защитена от скали с височина от 11 до 18 м. Тесен скален провлак я свързва със съседното плато Табиите. Между Калето и Табиите в миналото е имало дълъг дървен мост. Най-високата част на крепостта е т. нар. „Цитадела” със 166 м надморска височина. Овеч помни времето на Петър ІІ и Калоян, движението начело с цар Ивайло, рицарите на Амедей VІ Савойски, османското нашествие, антиосманското въстание от началото на ХV век, походът на полско-унгарския крал Владислав ІІІ Ягело. През ХІV век е седалище на митрополия. Днес личат основите на три църкви, жилищни сгради, разположени в северната част на твърдината, три входа (от север, изток и запад), отбранителни съоръжения, кладенец с дълбочина 79 м, единадесет щерни, 30 раннохристиянски гробници, улици и др. През 2008 г. Овеч е обявен за недвижим паметник на културата от национално значение.", "https://dobrini.bg/uploads/media/media.context.news/0001/03/thumb_2254_media.context.news_big.jpeg", "Крепост Овеч" },
                    { new Guid("cccf6684-6b37-4f0c-9618-8dc34b17642f"), new Guid("ff1c955c-57c1-4eaf-b17f-4f44e01fd4a8"), "Резерватът Сребърна е разположен край село Сребърна на 18 километра западно от Силистра и на 2 километра южно от Дунав. Той обхваща езерото Сребърна и неговите околности. Езерото е разположено край река Дунав. Резервата се намира на главното миграционно трасе на прелетните птици между Европа и Африка наречено \"Via Pontica\". Местността е обявена за резерват през 1948 г. и има охраняема площ от около 600 хектара, както и буферна зона от около 540 хектара. Дълбочината на езерото варира от 1 до 3 метра.Има изграден музей, в който е подредена експозиция от препарирани обитатели на резервата. От музея може да се наблюдават птиците в резервата. Поставена е видеокамера в сърцето на блатото, където гнездят пеликаните и чрез видеовръзка картината и звуците се предават на екран в музея. Около резервата е направена екопътека, като на известно разстояние по нея са построени беседки за отмора и наблюдателни площадки, откъдето може да се наблюдават птиците. Има няколко легенди за произхода на името,едната е за хан Сребрист ,който загива по тези места в неравен бой с печенегите. Втората легенда разказва за заровена лодка пълна със сребро по бреговете на блатото. Третата легенда ,която е най правдоподобна гласи ,че името идва от вълшебната картина наблюдавана вечерно време при пълнолуние. Когато луната е високо нейното отражение създава илюзията за разтопено сребро. Първият българин проявил интерес към това място е Алекси Петров , който е посетил резервата през 1911. Той бил запленен от красотата на птичия свят и запланувал поредица от експедиции. През 1913 год. обаче територията на резервата, заедно с цяла Южна Добруджа, попада в пределите на Румъния. С преминаването на територията отново в Българската държава Алекси Петров отново посещава резервата през 1940 г., за да проучи птичите колонии, гнездящи там. В миналото местността е посетена от Феликс Каниц, а през 1880 г. и друг австриец я посещава. Това е Едуард Ходек. Той описва своите впечатления в статията \"Домът на прелетниците\". Най-черната страница от историята на тази красива местност записва Лео фон Калберматен. Той и неговите хора избиват хиляди малки и големи чапли. Тогавашната мода е изисквала на дамските шапки да има пера от тези птици. Друг изследовател, посетил Сребърна е Отомар Райзер. Той е автор на книгата \"Материали на Българския орнис\", като втория том на книгата е посветена на българската фауна.", "https://i.ytimg.com/vi/NnK3EFg24vA/maxresdefault.jpg", "Резерват Сребърна" },
                    { new Guid("ccf7d0fa-c9ee-4b8a-a576-b05620b1afb8"), new Guid("233afddf-48f2-429a-834b-c851f4679d87"), "Тракийското скално светилище \"Беланташ\" се намира на около 30 км. югоизточно от гр. Асеновград. Представлява едновременно природен и културен феномен. Скалното плато е дълго около 300 метра и широко около 40 метра, а височината му е 50 метра. То е древно праисторическо и тракийско светилище, вероятно дори „древна обсерватория“. Легендите говорят, че от там тракийските жреци от местното племе беси са гадаели по звездите. Изсечени от човешка ръка, още в древността, груби стъпала водят към скално плато, осеяно със стотици малки и по-големи дупки – жертвени олтари на жреците. С \"Беланташ\" се свързва и култът към тракийския бог на Слънцето – Сабазий. Мястото е било най-активно използвано през първото хилядолетие преди н. е., макар, че високо развита древна цивилизация е съществувала по тези места от много по-рано. Предмет на научен интерес от почти четири десетилетия, самият \"Беланташ\", като име, се приема в превод - „добър, бял камък“ или „камък на знанието“. Наричат го справедливо още и българският Стоунхендж. В разположението на скалните ямки учени забелязват съразмерността на съзвездията Малка мечка и Голяма мечка, Лъв и Орион. Някои вярват, че местността може да е свързана с легендата за Потопа и Ноевия ковчег и, че в скалите на платото личат следи от халки, за които били придържани въжета на Кораба. Предания сочат, че преди повече от три десетилетия на \"Беланташ\" е забелязана небесна карта в знаците на платото. Има твърдение, според което в основата на скалния феномен са издълбани знаци, напомнящи указател. Наложени върху съвременна карта, те маркират точно комплекса от светилища в тази част на Родопите: Долнослав, Драганица, \"Беланташ\", \"Караджов камък\".", "https://www.visitplovdiv.com/sites/default/files/belintash.jpg", "Белинташ" },
                    { new Guid("d70c8fc6-9a4c-4c9b-bd78-b86a5ae42b26"), new Guid("d7f43f14-7fd6-4416-bb24-067cc0d4beeb"), "Демир баба теке е един от няколкото изключително интересни за посещение обети с културен исторически и религиозен характер в Историко-археологическия резерват „Сборяново” в близост до село Свещари, община Исперих, Разградска област. Демир баба теке всъщност е гробницата на един от най-почитаните алевийски светци в България – Демир баба. До извор в долината на река Крапинец през ХVІ-ти век върху стари тракийски и християнски храмове е построена гробницата на известният като „Железният баща” - Шейх Хасан Демир баба Пехливан. Светецът през средните векове помогнал за разпространението в тази част на Лудогорието на алевизма – течение в исляма, близко до шиизма. За него сред местното население се носят множество легенди. Според една от тях когато веднъж настъпила суша, Демир баба бръкнал с ръката си в земните недра и на мястото бликнал изворът „Бешпармак”, което ще рече – „Петте пръста”. Вярва се, че водата му е с лечебна сила и затова се посещава по Гергьовден, Илинден и Димитровден от алевии, мюсюлмани и християни. Текето на Демир баба е седмоъгълна монументална каменна постройка с купол, която прилича на джамия, но без минаре. Различава ги още и това, че то е своеобразна гробница, в която се намира саркофаг с костите на първия духовен алевийски водач (баба), заселил се в района. Този саркофаг винаги е затрупан от дебел пласт дарове. Днес ритуалите за позагубили част от своя колорит, но символикта остава важна част от религиозните обреди.", "https://boryanakrasteva.files.wordpress.com/2019/09/10.png?w=2000&h=1200&crop=1", "Демир Баба теке" },
                    { new Guid("e2513d54-afc4-4f03-9097-216f7d2a9720"), new Guid("f7e3ef46-c077-48db-9655-dfbb6849b39f"), "Връх Мусала се намира в източната част на Рила планина. Той е посещаван от много български и чуждестранни туристи. Върхът е много красив и предлага чудни гледки към останалата част от планината. Той е най-високият връх на Рила, на България и на целия Балкански полуостров. Връх Мусала е висок 2925 метра и 40 сантиметра, извисява се над красиви езера и се намира близо до други красиви върхове. На него има изградени метеорологична станция на националния институт по метеорология и хидрология при БАН и базова екологична обсерватория Мусала на института за ядрени изследвания и ядрена енергетика. До върха се стига по няколко маршрута, като един от най-предпочитаните е през Боровец и от там с лифт до хижа, след което се върви няколко часа пеша. По пътя към върха можете да видите много невероятни гледки, включително уникални панорами, много диви животни като: ястреб,орел, белка, златка, лисица и много други. Връх Мусала е част от 100-те национални туристически обекта, както и 10-те планински първенци на Българския туристически съюз. Върхът може да се изкачва целогодишно, но най-удобно е през летния сезон, тъй като тогава условията са най-приятни. Името на върха произлиза от арабски език – мусалла, което означава пътят към Бога, място близо до Бога или място за молитва. Върхът е изграден от палеозойски гранит с гранитпофирни жили. Той е покрит с алпийска растителност и поради неговата голяма височина няма много растения.", "https://zelenastrandja.com/products/137.jpg", "Връх Мусала" },
                    { new Guid("e5382c3e-f637-4e5c-9989-c5be07493130"), new Guid("233afddf-48f2-429a-834b-c851f4679d87"), "Бачковският манастир „Успение Богородично” се намира на южния край на родопското село Бачково, на 10 км южно от Асеновград. Манастирът е основан през 1083 г. от грузинеца Григорий Бакуриани, който направил дарение за изграждането му. Дълго време манастирът е бил грузински. От създаването му е запазена двуетажната костница, която се намира на около 400 м от него. Към края на ХІІ и началото на ХІІІ век е изградена зимната църква на манастира „Свети Архангели”, така че да се свързва с чардаците от втория етаж на западното крило, където са били монашеските килии. Смята се, че след падането на България под oсманско владичество (края на XIV век) в Бачковския манастир е бил заточен последният български патриарх – Eвтимий. Изграждането на нови манастирски сгради започва в края на ХVІ в., най-вероятно тогава е изградено и източното крило с укрепената главна порта. През 1601 г. е преизградено южното крило, където се намира магерницата и просторна трапезария с мраморна маса. Върху нея посетителите могат да видят годината на строителството. На северната стена на трапезарията през 1864 г. е изографисана сцената „Изнасянето на чудотворната икона”. През 1604 г. е построена съборната черква „Успение Богородично”, която е трикорабна, едноапсидна, с притвор и купол. През 1833 г. стопанският двор бил разширен и застроен с нови сгради. В периода 1834 – 1837 г. е построена третата църква, посветена на св. Никола. Захарий Зограф, известният български иконописец (1810 - 1853 г.) я изписва в периода 1838 – 1840 г., а през 1841 г. той украсява и преддверието на църквата „Св. Архангели”. В съборната църква е запазена иконата на „Св. Богородица” със сребърен обков от 1311 г., която е смятана за чудотворна. В манастира могат да бъдат видени икони, сребърни обкови за евангелия и други художествени творби, датиращи от ХVІ - ХІХ в. От ХVІІ в. са останали дърворезбованата структура на позлатения иконостас и царските двери в главната църква. В съборната църква са погребани българският екзарх Стефан І (1878 – 1957) и българският патриарх Кирил (1901 – 1971). Към манастира има музей, в който се съхраняват някои от най-старите предмети, свързани с историята му.", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Monastere_batchkovo.jpg/1200px-Monastere_batchkovo.jpg", "Бачковският манастир" },
                    { new Guid("f1db13c9-5269-4b19-8f76-001bee36de5b"), new Guid("5bc79020-4a92-43fb-9c97-7550bdc8f6c9"), "След Освобождението на България през 1878 година Великото народно събрание избира първия български княз - Александър І Батенберг. Владетелят на младата държава няма нито княжески дворец, нито резиденция. На 16 март 1882 година във Варна той получава като подарък от Гръцката митрополия малкия манастир \"Св. Димитър\", построен през 1821 година, и прилежащите му имоти - лозя, скалисти и каменисти брегове. Впоследствие манастирът бил превърнат (по времето на княз Фердинанд) в малка резиденция. В близост до нея бил и манастирът „Св. св. Константин и Елена“. По-късно, княз Александър разширил имота до съвременната му площ от 80 хектара (0.80 км2). Най-напред е построен дворецът, като постепенно около него се изгражда паркът. За близо половин век някогашният недружелюбен и каменист бряг се превръща от \"грозно патенце\" в \"прекрасен лебед\". Той става любимо място за почивка и морски бани на княза. Хората го наричат \"Сандрово\", по името Сандро, с което Александър І е известен сред близките си. Князът пристигал с файтон от Варна, ескортиран от лична охрана гвардейци. С крайморския княжески дворец са свързани важни събития около обявяването на Съединението. Именно тук на 6 септември 1885 княз Александър І, който пристигнал седмица по-рано на почивка, подписва Указа за Съединението на Княжество България с Източна Румелия.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Euxinograd_2017_77.jpg/1200px-Euxinograd_2017_77.jpg", "Дворецът Евксиноград" },
                    { new Guid("f243d36e-82ce-4968-85d0-3f0c433aacac"), new Guid("48d5bcd4-c99e-4796-8843-852cae764175"), "Перперикон се смята за един от символите на магичните Родопи. Той се състои от древно мегалитно светилище, средновековна крепост и редица паметници. Според данните градът датира от VI-V хилядолетие преди Христа и в него са живели траки, готи, ромеи, римляни и българи. Според историците мястото е било светилище на бога на виното и веселието Дионис. Изследванията и разкопките по него започват още от 1931 година и през 1968 година е обявен за паметник на културно наследство от национално значение. Всъщност истинското наименование на свещения град е Перперик. Той е с площ 5000 кв.м., което го прави най-голямото мегалитно светилище на целия Балкански полуостров. Хората смятат, че Перперикон носи много силна енергия, която предава на посетителите си. За жалост през близката 1990 година, иманяри успяват да ограбят част от артикулите в гробниците.", "https://epicenter.bg/images/news/42021/pics/1617710543.jpg", "Перперикон" },
                    { new Guid("f5b3b29e-564a-4f79-8b79-e709515a7d7d"), new Guid("006902e5-3b36-42da-a288-77a33f44f021"), "Рилският манастир, или по-добре казано Съкровищницата на България, благолепно и неувяхващо цъфти в лоното на Рила планина, там, където богато се вливат реките Друшлявица и Рилска. Основан през първата половина на Х в. от небесния закрилник на българския народ преподобни Йоан Рилски, манастирът и до днес е люлка, стожер и хранилище на българския дух, и народност. Докато сведенията за съдбата на мощите на св. Йоан през Х – ХІV в. са подробни, за самата Рилска обител те са оскъдни. От ХІ в. до днес в манастирското книгохранилище се пазят книжовни паметници, като глаголическия препис на прочутото „Наставление” на св. Ефрем Сирин, които свидетелстват за непрекъсната книжовна дейност. В Хрисовула (дарствена грамота) на цар Иван Шишман (1371 – 1393 г.) се говори за това, че българските държавници – царете Иван Асен ІІ (1218 – 1241 г.) и неговият приемник Каломан (1241 – 1246 г.) са утвърждавали владенията и правата на обителта, и я почитали като огнище на святост и място на поклонение. През 1334 – 1335 г. Струмишкият протосеваст Хрельо, щедър дарител на Хилендарския манастир, изгражда защитна кула, монашески килии и храм, който бил на мястото на днешния, построен през 1834 г. През време на турското владичество (ХV – ХІХ в.) Рилския манастир става център на духовно, културно и книжовно самосъхранение и възраждане на българския дух и народност. След като била опожарена Търновската книжовна школа се премества в обителта. Рилската библиотека бива възобновена и обогатена с нови ръкописи. Към края на ХVІІ в. била създадена книговезка работилница. Установени били връзки със Светогорски манастири, а през 1466 г. бил подписан договор с руския манастир на Света Гора „Св. Пантелеймон” за взаимно подпомагане и даване на убежище в случай на опасност. От XVI в. датират и връзките с Русия, където през следващите столетия няколко пъти били изпращани рилски монаси за събиране на дарения (книги, икони, църковна утвар, богослужебни одежди, парични средства). През Възраждането (ХVІІІ – ХІХ в.) в Рилската обител се откриват школи и училища. Изтъкнатият книжовник и игумен на манастира (от 1860 до 1864 г.) иеромонах Неофит Рилски – Патриарх на българската педагогика, подготвя учители и духовници за цялата страна. Той е основател и пръв учител на прочутата Габровска гимназия. След освобождението на България от османско владичество духовният живот в обителта продължава своя разцвет, а нетленните мощи на св. Йоан Рилски и до днес са извор на утеха, чудеса и небесна помощ за пристъпващите към тях с вяра.", "https://bookvila.bg/img/210209073027.jpg", "Рилски манастир" }
                });

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name" },
                values: new object[] { new Guid("fee6dc9f-4348-4a0a-8bcf-1a4b3cce6f18"), new Guid("233afddf-48f2-429a-834b-c851f4679d87"), "Античният театър на Филипополис е сред най-добре запазените антични театри в света и сред основните туристически атракции на Пловдив. Построен е по времето на римския император Марк Улпий Траян (98 – 117) сл. Хр. и е разкрит при археологически разкопки от 1968 до 1979 г. от Археологически музей Пловдив. Разположен е между Джамбаз тепе и Таксим тепе. Театърът на Филипопол e единствената запазена антична театрална сграда по българските земи. Сградата е адаптирана за съвременния културен живот на Пловдив и в нея се провеждат различни по характер спектакли за около 3500 зрители. Обявен е за археологически паметник в брой. 6 на Държавен вестник от 1995 г. Според открит строителен надпис върху фриз-архитрава от източния проскений, построяването на театъра е станало по времето на римския император Марк Улпий Траян (98 – 117). По подобие на театрите по цялата Римска империя, така и на театъра във Филипопол почетните зрителски места са надписвани. Освен за представителите на градската управа, обозначения има за магистрати, приятели на императора и др. Откритите почетни надписи показват, че сградата е използвана и за седалище на тракийското провинциално събрание. Вероятно част от зрелищата с борби с животни и гладиатори са се провеждали в театъра, тъй като съществуват специфични особености на конструкцията му. Открити са следи от обезопасителни съоръжения пред първия ред и трите стълбища, които пресичат подиума. Най-вероятно тези допълнения са направени във връзка с посещението на император Каракала във Филипопол през 214 г.", "https://tripsjournal.com/wp-content/uploads/2016/03/Antichen-teatyr-Plovdiv.jpg", "Античният театър" });

            migrationBuilder.InsertData(
                table: "Resorts",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name", "Stars", "Type" },
                values: new object[,]
                {
                    { new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), new Guid("d36b4336-8391-4da7-b0df-e7a2555d07f6"), "Гранд Хотел Княз Павел се намира в Павел Баня, на 31 км от еко пътека „Бяла река“. Предлага помещения за настаняване с безплатен частен паркинг, открит плувен басейн, фитнес център и градина. Този 5-звезден хотел разполага с тераса и климатизирани стаи с безплатен WiFi и самостоятелна баня. Гостите могат да ползват спа и уелнес центъра със закрит басейн, сауна и хидромасажна вана, както и общия салон. Всички стаи в хотела включват балкон с изглед към града. Всяка стая е снабдена с кафемашина, а някои стаи имат кухненски бокс с микровълнова фурна. Стаите за гости в Гранд Хотел Княз Павел са оборудвани с телевизор с плосък екран и сешоар. В мястото за настаняване ще намерите ресторант, предлагащ местна, международна и европейска кухня. Гостите могат да заявят вегетариански, безмлечни и халал храни. Можете да играете тенис на маса в Гранд Хотел Княз Павел, а районът е популярен за колоездене. Персоналът на денонощната рецепция говори български и английски език. Връх Шипка е на 36 км от хотела. Най-близкото летище е международно летище Пловдив, на 104 км от Гранд Хотел Княз Павел. Летищен трансфер се осигурява срещу допълнително заплащане.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/392067768.jpg?k=e35eb4efe7e2385667b4036a21e874eadbe0068335b6a220c838c63308d31c3c&o=&hp=1", "Гранд Хотел Княз Павел", "5", "Хотел" },
                    { new Guid("4e2d6327-b6f3-44b0-a892-242ac5e00d35"), new Guid("5bc79020-4a92-43fb-9c97-7550bdc8f6c9"), "Този модерен 5-звезден хотел се намира в центъра на Варна, на 400 м от брега на Черно море и точно до спирката на автобусите до Златни пясъци. Всяка стая съчетава елегантно обзавеждане с модерен дизайн. Хотел Галерия Графит предлага стилни стаи за непушачи с климатик, кабелна/сателитна/интерактивна телевизия и безплатен WiFi. Някои стаи включват собствен балкон. Просторните модерни бани са снабдени с халати и сешоар. Гостите могат да се възползват от добре оборудваната зона за релакс, където има закрит басейн с панорамни прозорци. Фитнес залата е до басейна, от който се открива гледка към града. Съоръженията се допълват от сауна и зала за масажи. В ресторанта на хотел Графит, Red Canape, се приготвят ястия от българската и международната кухня, а в кафенето се сервират вкусни сладкиши и топли напитки през деня и ароматни коктейли вечерта. ", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/172620710.jpg?k=1e8072a1ac46bfae5f0fd806d297aaf7ab8e0a5ae3c114b36e47b8bf059dd027&o=&hp=1", "Хотел Галерия Графит", "5", "Хотел" },
                    { new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), new Guid("f612bb1f-975e-434a-920b-5c886ebe3cc6"), "Хотел Kings' Valley Medical & Spa се намира в Казанлък, на 32 км от търговски център „Мол Галерия“. Предлага помещения за настаняване със сезонен открит плувен басейн, безплатен частен паркинг, фитнес център и градина. Разполага с ресторант, тераса, закрит басейн и хидромасажна вана. Хотелът разполага с вана с гореща минерална вода, рум-сървиз и безплатен WiFi на цялата площ. Всички стаи в хотела разполагат с климатик, кът за сядане, телевизор с плосък екран със сателитни канали, сейф и собствена баня с биде, безплатни тоалетни принадлежности и сешоар. Хотел Kings' Valley Medical & Spa предлага някои помещения с балкон, а всички стаи са оборудвани с кафемашина. Стаите са снабдени със спално бельо и хавлии. Всяка сутрин в хотел Kings' Valley Medical & Spa се сервира закуска на шведска маса. Хотелът разполага със СПА център. В този 5-звезден хотел има тенис корт, а районът е популярно място за колоездене. Персоналът на рецепцията говори български и английски език и е на разположение денонощно. Регионалният исторически музей на Стара Загора и художествената галерия на Стара Загора са на 34 км от хотел Kings' Valley Medical & Spa.", "https://cf.bstatic.com/xdata/images/hotel/max1280x900/481079013.jpg?k=a7de84475d2fc06650a290ebdf1de75ad7306ae9726537a5e775241902869fb7&o=&hp=1", "Kings' Valley Medical & Spa Hotel", "5", "Хотел" },
                    { new Guid("bca59868-70b8-481e-8e66-88b6e4a32fb6"), new Guid("7a65d489-304c-4be8-b344-7d53a644e080"), "Къща за гости Елизабет се намира в центъра на Самоков, на 10 минути с кола от ски курорта Боровец. Предлага лятна градина с кът за сядане, безплатен WiFi във всички части и безплатен собствен паркинг. Всички стаи в къща за гости Елизабет разполагат с модерни удобства като кабелна телевизия и самостоятелна баня с душ и сешоар. Някои от просторните помещения за настаняване включват отделна всекидневна, хидромасажна вана и камина. Малките гости могат да се забавляват на детската площадка в градината. Около къщата за гости има различни ресторанти и заведения за хранене. На място се използва машина за химическо чистене, която е подходяща за хора с алергии. Къща за гости Елизабет е на около 30 минути с кола от минералните извори и плувни басейни в Сапарева баня, Долна баня и Белчински бани.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/30551820.jpg?k=39060232600fb6055f2bc2c60c3a8ff98cb2ea9554f2fb5988d8811083bca462&o=&hp=1", "Къща за гости Елизабет", "3", "Къща за гости" }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Gym", "Parking", "Pool", "ResortId", "Restaurant", "RoomService", "SpaCenter", "Wifi" },
                values: new object[,]
                {
                    { new Guid("05561c69-9cf4-457d-9e31-1f8013408d1f"), true, false, true, new Guid("4e2d6327-b6f3-44b0-a892-242ac5e00d35"), true, true, true, true },
                    { new Guid("14efad0c-abb9-4ec1-a003-7b3c0737b2eb"), true, true, true, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), true, true, true, true },
                    { new Guid("1acd5dac-7a3e-474d-95f4-e94f2a0fe2bb"), true, true, true, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), true, true, true, true },
                    { new Guid("850ca647-84d3-4872-81eb-def5676ddd02"), false, false, false, new Guid("bca59868-70b8-481e-8e66-88b6e4a32fb6"), false, false, false, true }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Description", "PricePerNight", "ResortId", "Type" },
                values: new object[,]
                {
                    { new Guid("180592ca-bea7-4053-bb15-1071c22e0bee"), "2", "Тази двойна стая предлага разкош и удобство за двама гости. Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.", 150m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Двойна стая" },
                    { new Guid("2700d8b7-c588-4435-a761-8c3cb246ea09"), "2", "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 220m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Студио" },
                    { new Guid("27552f30-4dde-4d85-bad1-4c6b05843fee"), "2", "Тази двойна стая предлага разкош и удобство за двама гости. Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.", 150m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Двойна стая" },
                    { new Guid("2f4a8de0-5a11-4846-950a-40a566667551"), "2", "Тази двойна делукс стая е символ на разкош и комфорт, предназначена за двама гости, които ценят изискаността и уютa. В нея се предлага просторно пространство, разкошно кралско легло, допълнено с висококачествено спално бельо и меки възглавници. Банята е обичайно обзаведена с изискани детайли и висок клас санитарни удобства, с модерна мраморна облицовка. Освен това, стаята може да разполага с голям балкон, предлагащ чудесен изглед към околната природа, за да създаде пълноценно усещане за релаксация и лукс.", 170m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Двойна делукс стая" },
                    { new Guid("40ff5444-5179-4c83-a1f3-637b50d04bce"), "2", "Тази двойна делукс стая е символ на разкош и комфорт, предназначена за двама гости, които ценят изискаността и уютa. В нея се предлага просторно пространство, разкошно кралско легло, допълнено с висококачествено спално бельо и меки възглавници. Банята е обичайно обзаведена с изискани детайли и висок клас санитарни удобства, с модерна мраморна облицовка. Освен това, стаята може да разполага с голям балкон, предлагащ чудесен изглед към околната природа, за да създаде пълноценно усещане за релаксация и лукс.", 170m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Двойна делукс стая" },
                    { new Guid("428c043a-5142-4197-bbb7-6ccfa3216ec4"), "4", "Нашият отлично обзаведен Гранд суит осигурява незабравим уют и комфорт. Тази стая разполага с 2 просторни спални, 2 просторни мраморни бани, състоящи се от душ и вана и голям балкон с маса за хранене и няколко люлки. Всички наши стаи разполагат със смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Кафе машина Неспресо и хигиенни удобства Омния са осигурени във всяка стая.", 509m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Апартамент" },
                    { new Guid("5448199b-bbcf-4ea5-a120-417ca95a5933"), "2", "Тази двойна стая представлява уютно и функционално обзаведено пространство, предназначено за двама гости. Разполага с едно двойно легло, съчетано с удобства като частна баня и основни удобства за комфортен престой. Такива стаи предоставят и приятна атмосфера, която позволява на гостите да се почувстват като у дома си, като същевременно се наслаждават на почивката си в нова среда.", 77m, new Guid("bca59868-70b8-481e-8e66-88b6e4a32fb6"), "Двойна стая" },
                    { new Guid("59b6ca47-8cde-44fa-a927-a4b68a346e49"), "2", "Двойната делукс стая представлява изискано и уютно пространство, създадено за двама гости, които търсят по-високо ниво на комфорт и удоволствие. Разполага с изключително удобно двойно легло, обградено от елегантно спално бельо и меки възглавници. Банята е модерна и стилно обзаведена, с използване на висок клас санитарни удобства. Освен това, двойната делукс стая предлага и допълнителни удобства като голям балкон и разкошна гледка, за да осигури на гостите незабравимо преживяване в уютна и разкошна обстановка.", 85m, new Guid("bca59868-70b8-481e-8e66-88b6e4a32fb6"), "Двойна делукс стая" },
                    { new Guid("5d90e4f8-dd39-4534-ba7b-e3d44bb049f9"), "2", "Тази двойна стая предлага разкош и удобство за двама гости. Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.", 150m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Двойна стая" },
                    { new Guid("64934542-3e3c-4292-9275-8370a627564d"), "2", "Нашите луксозно обзаведени двойни стаи предлагат незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон. Всички наши стаи разполагат със спалня или две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 220m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Двойна делукс стая" },
                    { new Guid("69dec351-64bf-49b4-add7-069abb03735c"), "2", "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 220m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Студио" },
                    { new Guid("6f2d2bf9-a88b-4b78-bcaa-3e49ce30dd04"), "2", "Нашите луксозно обзаведени двойни стаи предлагат незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон. Всички наши стаи разполагат със спалня или две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 220m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Двойна делукс стая" },
                    { new Guid("79a20b3e-e31a-4156-970a-f566350de8b4"), "2", "Тази двойна делукс стая е символ на разкош и комфорт, предназначена за двама гости, които ценят изискаността и уютa. В нея се предлага просторно пространство, разкошно кралско легло, допълнено с висококачествено спално бельо и меки възглавници. Банята е обичайно обзаведена с изискани детайли и висок клас санитарни удобства, с модерна мраморна облицовка. Освен това, стаята може да разполага с голям балкон, предлагащ чудесен изглед към околната природа, за да създаде пълноценно усещане за релаксация и лукс.", 160m, new Guid("4e2d6327-b6f3-44b0-a892-242ac5e00d35"), "Двойна делукс стая" },
                    { new Guid("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d"), "2", "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 206m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Двойна стая" },
                    { new Guid("7fae328e-d8ea-415d-ba51-eb32b9e9dce5"), "2", "Тази двойна стая предлага разкош и удобство за двама гости. Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.", 130m, new Guid("4e2d6327-b6f3-44b0-a892-242ac5e00d35"), "Двойна стая" },
                    { new Guid("814209b2-06f6-47ac-9a3d-e4ac16c7382a"), "2", "Тази двойна стая представлява уютно и функционално обзаведено пространство, предназначено за двама гости. Разполага с едно двойно легло, съчетано с удобства като частна баня и основни удобства за комфортен престой. Такива стаи предоставят и приятна атмосфера, която позволява на гостите да се почувстват като у дома си, като същевременно се наслаждават на почивката си в нова среда.", 77m, new Guid("bca59868-70b8-481e-8e66-88b6e4a32fb6"), "Двойна стая" },
                    { new Guid("86a5daf7-e168-4ef4-9b98-f99f50e30151"), "2", "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 206m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Двойна стая" },
                    { new Guid("9c64d851-359c-410d-a740-3d4033ed8b71"), "2", "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 206m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Двойна стая" },
                    { new Guid("a8c6414d-3e0d-4163-8ad4-40c5bb9b9fc5"), "2", "Тази двойна делукс стая е символ на разкош и комфорт, предназначена за двама гости, които ценят изискаността и уютa. В нея се предлага просторно пространство, разкошно кралско легло, допълнено с висококачествено спално бельо и меки възглавници. Банята е обичайно обзаведена с изискани детайли и висок клас санитарни удобства, с модерна мраморна облицовка. Освен това, стаята може да разполага с голям балкон, предлагащ чудесен изглед към околната природа, за да създаде пълноценно усещане за релаксация и лукс.", 160m, new Guid("4e2d6327-b6f3-44b0-a892-242ac5e00d35"), "Двойна делукс стая" },
                    { new Guid("a95989bc-ab2d-43dc-90f7-21f6b4cc6d8c"), "4", "Суитът в хотела представлява върха на лукса и комфорта, като предлага на гостите просторен и стилно обзаведен апартамент. Този вид стая често включва отделна спалня, просторна дневна зона със собствен бар и елегантен санитарен възел с вана или душ. Суитът е подходящ за гости, които ценят изисканото удобство и желаят да се насладят на привилегировано пребиваване в хотела.", 330m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Апартамент" },
                    { new Guid("aa797062-fc24-4f63-953d-8a8445b15e7d"), "2", "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 206m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Двойна стая" },
                    { new Guid("c65343e9-d496-4add-9978-947bee062a81"), "2", "Нашите отлично обзаведени стандартни двойни стаи осигуряват незабравим уют и комфорт. Такава стая разполага с просторна мраморна баня и балкон, две отделни легла, смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Хигиенни удобства Омния са осигурени във всяка стая.", 206m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Двойна стая" },
                    { new Guid("c67902e0-bfc4-4ea9-8112-d99f1a1a1ad7"), "2", "Двойната делукс стая представлява изискано и уютно пространство, създадено за двама гости, които търсят по-високо ниво на комфорт и удоволствие. Разполага с изключително удобно двойно легло, обградено от елегантно спално бельо и меки възглавници. Банята е модерна и стилно обзаведена, с използване на висок клас санитарни удобства. Освен това, двойната делукс стая предлага и допълнителни удобства като голям балкон и разкошна гледка, за да осигури на гостите незабравимо преживяване в уютна и разкошна обстановка.", 85m, new Guid("bca59868-70b8-481e-8e66-88b6e4a32fb6"), "Двойна делукс стая" },
                    { new Guid("d1ea883d-29de-4cdc-a5ec-d65a915df524"), "4", "Нашият отлично обзаведен Гранд суит осигурява незабравим уют и комфорт. Тази стая разполага с 2 просторни спални, 2 просторни мраморни бани, състоящи се от душ и вана и голям балкон с маса за хранене и няколко люлки. Всички наши стаи разполагат със смарт телевизори с многоезични канали и интерактивни услуги за гости. Интелигентен панел, контролиращ както поддръжката на помещението, така и температурата. Кафе машина Неспресо и хигиенни удобства Омния са осигурени във всяка стая.", 509m, new Guid("38b0b8f7-271d-4b03-98dc-03e7d6269478"), "Апартамент" },
                    { new Guid("d2304ebf-e36c-4ab4-a5cb-4cee96b16594"), "4", "Суитът в хотела представлява върха на лукса и комфорта, като предлага на гостите просторен и стилно обзаведен апартамент. Този вид стая често включва отделна спалня, просторна дневна зона със собствен бар и елегантен санитарен възел с вана или душ. Суитът е подходящ за гости, които ценят изисканото удобство и желаят да се насладят на привилегировано пребиваване в хотела.", 330m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Апартамент" },
                    { new Guid("d2d41dc4-f7ef-4267-af5d-01e413c7f133"), "2", "Тази двойна стая предлага разкош и удобство за двама гости. Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.", 130m, new Guid("4e2d6327-b6f3-44b0-a892-242ac5e00d35"), "Двойна стая" },
                    { new Guid("e7a0ce16-bd47-423e-9502-9c3f5354cce7"), "2", "Тази двойна стая предлага разкош и удобство за двама гости. Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.", 130m, new Guid("4e2d6327-b6f3-44b0-a892-242ac5e00d35"), "Двойна стая" },
                    { new Guid("f085410f-9f1c-445c-a054-9c9e2d5dc538"), "2", "Тази двойна стая предлага разкош и удобство за двама гости. Обикновено е обзаведена с две отделни легла с висококачествено спално бельо и матраци. Банята е модерна и стилно обзаведена с висок клас санитарни удобства и елегантни мраморни плочки. Стаите също разполагат със смарт телевизори и балкони с красив изглед, предлагайки на гостите уютна и комфортна среда за престой.", 150m, new Guid("6016de68-9999-4e82-aee8-ac1f6a9491c3"), "Двойна стая" },
                    { new Guid("f3ede3a4-fa72-44fb-8553-2c7b992050eb"), "2", "Тази двойна стая представлява уютно и функционално обзаведено пространство, предназначено за двама гости. Разполага с едно двойно легло, съчетано с удобства като частна баня и основни удобства за комфортен престой. Такива стаи предоставят и приятна атмосфера, която позволява на гостите да се почувстват като у дома си, като същевременно се наслаждават на почивката си в нова среда.", 77m, new Guid("bca59868-70b8-481e-8e66-88b6e4a32fb6"), "Двойна стая" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "RoomId", "Url" },
                values: new object[,]
                {
                    { new Guid("16b9815c-312b-425f-9457-5e0aac9b9b9f"), new Guid("2700d8b7-c588-4435-a761-8c3cb246ea09"), "https://knyazpavel.com/wp-content/uploads/2022/07/g-studio-3.jpg" },
                    { new Guid("287ec125-d9ac-4812-875c-c25a1edbd26a"), new Guid("2f4a8de0-5a11-4846-950a-40a566667551"), "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-deluxe-1.jpg" },
                    { new Guid("2e5b99e7-f348-44e1-bc48-5a0c931609cd"), new Guid("e7a0ce16-bd47-423e-9502-9c3f5354cce7"), "https://secure.exely.com/resource/images/rt/115277/637208410773519493-30162600-3c56-4778-a706-4f3d0df5df13" },
                    { new Guid("3753e392-e28d-45ce-a14e-cd4b4747e60f"), new Guid("428c043a-5142-4197-bbb7-6ccfa3216ec4"), "https://knyazpavel.com/wp-content/uploads/2022/10/g-grand-suite-4.jpg" },
                    { new Guid("3c3bf7e9-fe86-4f7f-b901-cd757a5ce106"), new Guid("428c043a-5142-4197-bbb7-6ccfa3216ec4"), "https://knyazpavel.com/wp-content/uploads/2022/10/g-grand-suite-1.jpg" },
                    { new Guid("41f6bdb1-7924-445c-a613-2f8633adbf37"), new Guid("a8c6414d-3e0d-4163-8ad4-40c5bb9b9fc5"), "https://secure.exely.com/resource/images/rt/115278/637199615874092347-ac4a8004-136b-474b-a422-6dbb36c5e5bd" },
                    { new Guid("5ecb5d89-3bad-499c-8829-122373b78d1a"), new Guid("d2304ebf-e36c-4ab4-a5cb-4cee96b16594"), "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-junior.jpg" },
                    { new Guid("61b4df33-b86b-4b73-b212-c5d57c48e6a5"), new Guid("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d"), "https://knyazpavel.com/wp-content/uploads/2022/07/g-standard-room-1.jpg" },
                    { new Guid("757260dd-8734-4561-81c7-d084463e75b6"), new Guid("c67902e0-bfc4-4ea9-8112-d99f1a1a1ad7"), "https://cf.bstatic.com/xdata/images/hotel/max1024x768/28526876.jpg?k=f67a479c6e2a572518f27f18d4b02c3dccd6ef52dfd2deca33decf3a3513b832&o=&hp=1" },
                    { new Guid("79414ac2-e348-470b-ad6f-ff70f4ef82e7"), new Guid("e7a0ce16-bd47-423e-9502-9c3f5354cce7"), "https://secure.exely.com/resource/images/rt/115277/637199615130730753-478d48e1-0f24-4453-98e0-2b7426f43ae6" },
                    { new Guid("7f4dd05e-defa-425a-b397-50f516ba0918"), new Guid("64934542-3e3c-4292-9275-8370a627564d"), "https://knyazpavel.com/wp-content/uploads/2022/07/g-deluxe-room-3.jpg" },
                    { new Guid("7fda1cee-e088-42bd-a96d-7bb2668ff1ac"), new Guid("6f2d2bf9-a88b-4b78-bcaa-3e49ce30dd04"), "https://knyazpavel.com/wp-content/uploads/2022/07/g-deluxe-room-3.jpg" },
                    { new Guid("a681b116-c215-4afa-8bb9-5ada9aca8e14"), new Guid("d2304ebf-e36c-4ab4-a5cb-4cee96b16594"), "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-onebed-1.jpg" },
                    { new Guid("ae3b5a32-2b82-4564-9f66-0d42d37dcf3f"), new Guid("2700d8b7-c588-4435-a761-8c3cb246ea09"), "https://knyazpavel.com/wp-content/uploads/2022/07/g-studio-1.jpg" },
                    { new Guid("b1723baa-22bc-48a3-8f01-3a982ce2937f"), new Guid("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d"), "https://knyazpavel.com/wp-content/uploads/2022/07/g-standard-room-5.jpg" },
                    { new Guid("b73fa054-2ba6-4fcd-9e2b-11970fdd14c5"), new Guid("428c043a-5142-4197-bbb7-6ccfa3216ec4"), "https://knyazpavel.com/wp-content/uploads/2022/10/g-grand-suite-7.jpg" },
                    { new Guid("bfb98bd3-500b-4ae1-bdac-d8969fa72431"), new Guid("c67902e0-bfc4-4ea9-8112-d99f1a1a1ad7"), "https://cf.bstatic.com/xdata/images/hotel/max1024x768/79141090.jpg?k=8e2d3d5efc66fdf3d4be0a201bfbc5875498dc3f8b50cf9dfedbdedd6c8212ff&o=&hp=1" },
                    { new Guid("c7bfddd7-21e4-4889-a965-50658b2fc0b0"), new Guid("180592ca-bea7-4053-bb15-1071c22e0bee"), "https://cf.bstatic.com/xdata/images/hotel/max1024x768/269595082.jpg?k=c578ea8f75b5a3ffb94c0ca4d63c9a6c409917a8c667f25d5581998b14ee933e&o=&hp=1" },
                    { new Guid("c7e3e256-36ae-41df-8877-08177211dae6"), new Guid("180592ca-bea7-4053-bb15-1071c22e0bee"), "https://cf.bstatic.com/xdata/images/hotel/max1280x900/28526865.jpg?k=4b44f7b37a762ea94fd57532745360d8fa60bfe8dce69638e0a9055cd57ea082&o=&hp=1" },
                    { new Guid("c989374d-b63e-4644-b4a1-62442bfee31b"), new Guid("7f3c9e9d-124b-4b3c-bbc6-9e157dca781d"), "https://knyazpavel.com/wp-content/uploads/2022/07/g-standard-room-3.jpg" },
                    { new Guid("e08ac724-5e07-4339-a187-5289e888e519"), new Guid("a8c6414d-3e0d-4163-8ad4-40c5bb9b9fc5"), "https://secure.exely.com/resource/images/rt/115278/637199615874775089-69f03cf9-1bc4-4cae-9037-91a7a4e64d03" },
                    { new Guid("f952762b-02db-46b2-8a16-749a4b02c8e3"), new Guid("f085410f-9f1c-445c-a054-9c9e2d5dc538"), "https://kingsvalleyhotel.bg/wp-content/uploads/2023/05/z-superior-1.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_ResortId",
                table: "Facilities",
                column: "ResortId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Image_RoomId",
                table: "Image",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Landmarks_CityId",
                table: "Landmarks",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationUser_ReservationId",
                table: "ReservationUser",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Resorts_CityId",
                table: "Resorts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservation_RoomId",
                table: "RoomReservation",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ResortId",
                table: "Rooms",
                column: "ResortId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Landmarks");

            migrationBuilder.DropTable(
                name: "ReservationUser");

            migrationBuilder.DropTable(
                name: "RoomReservation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Resorts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
