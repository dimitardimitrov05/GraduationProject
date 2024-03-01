﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Резервирай_Преживяване.Data;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240223080752_addedColumnToResorts")]
    partial class addedColumnToResorts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Резервирай_Преживяване.Data.Account.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Postcode")
                        .IsUnique();

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05aeee56-395a-46ae-bc69-896ba5cec9e8"),
                            Name = "Бургас",
                            Postcode = "8000"
                        },
                        new
                        {
                            Id = new Guid("314b8784-469f-40a0-8818-1cef9ebdbcea"),
                            Name = "Варна",
                            Postcode = "9000"
                        },
                        new
                        {
                            Id = new Guid("1d677722-b8a3-45a0-91c0-0ed6557bad64"),
                            Name = "Силистра",
                            Postcode = "7500"
                        },
                        new
                        {
                            Id = new Guid("e2c8d267-e8cc-497d-89d2-d5fb31c245c0"),
                            Name = "Търговище",
                            Postcode = "7700"
                        },
                        new
                        {
                            Id = new Guid("960ceea7-8dde-4d32-92c0-9c1354fa2f89"),
                            Name = "Ловеч",
                            Postcode = "5500"
                        },
                        new
                        {
                            Id = new Guid("baf06b36-4d91-499e-a017-1f1bd6c1bab2"),
                            Name = "Кърджали",
                            Postcode = "6600"
                        },
                        new
                        {
                            Id = new Guid("6fc714ac-06e1-4eb8-a667-1084143730bc"),
                            Name = "Пловдив",
                            Postcode = "4000"
                        },
                        new
                        {
                            Id = new Guid("258be383-106a-4758-8e82-53dadc54c050"),
                            Name = "Добрич",
                            Postcode = "9300"
                        },
                        new
                        {
                            Id = new Guid("222525ed-cbd8-406a-8db3-ec2238d4d359"),
                            Name = "София",
                            Postcode = "1000"
                        },
                        new
                        {
                            Id = new Guid("62828987-0027-4aa8-8ce6-1847d0fbbd4b"),
                            Name = "Благоевград",
                            Postcode = "2700"
                        },
                        new
                        {
                            Id = new Guid("a3d80fd6-33e1-4778-bbe7-b70fc9243275"),
                            Name = "Пазарджик",
                            Postcode = "4400"
                        },
                        new
                        {
                            Id = new Guid("64b64395-9ce1-4630-9c81-3098540c98c0"),
                            Name = "Перник",
                            Postcode = "2300"
                        },
                        new
                        {
                            Id = new Guid("2218aecc-54ce-4f92-8a4d-fdc71a48db56"),
                            Name = "Плевен",
                            Postcode = "5800"
                        },
                        new
                        {
                            Id = new Guid("6ba5d16c-6ee5-4d4e-bcd0-38622b923950"),
                            Name = "Видин",
                            Postcode = "3700"
                        },
                        new
                        {
                            Id = new Guid("0c3d7e1c-6993-4754-9429-9c1ae1368a8d"),
                            Name = "Монтана",
                            Postcode = "3400"
                        },
                        new
                        {
                            Id = new Guid("22fcc972-be16-4d12-8393-acbd85c0202b"),
                            Name = "Кюстендил",
                            Postcode = "2500"
                        },
                        new
                        {
                            Id = new Guid("e3190d3a-e6ef-46a8-acdf-aad846558408"),
                            Name = "Ямбол",
                            Postcode = "8600"
                        },
                        new
                        {
                            Id = new Guid("38388f9e-8aa2-4cb9-ab31-fbac6af39930"),
                            Name = "Русе",
                            Postcode = "7000"
                        },
                        new
                        {
                            Id = new Guid("91ee2830-cca7-4a91-932d-abd58c13d4e3"),
                            Name = "Враца",
                            Postcode = "3000"
                        },
                        new
                        {
                            Id = new Guid("35fd1dca-f85c-4a49-b0fb-bdae82eaf3bb"),
                            Name = "Велико Търново",
                            Postcode = "5000"
                        },
                        new
                        {
                            Id = new Guid("8b96a4f6-f4de-4dc3-8965-d457e51dd4cb"),
                            Name = "Шумен",
                            Postcode = "9700"
                        },
                        new
                        {
                            Id = new Guid("c92a5367-5064-4004-b535-1a3c7ede0780"),
                            Name = "Габрово",
                            Postcode = "5300"
                        },
                        new
                        {
                            Id = new Guid("ea12299d-76dc-4095-8575-365affe8d8a9"),
                            Name = "Разград",
                            Postcode = "7200"
                        },
                        new
                        {
                            Id = new Guid("01722f58-060e-4261-9f53-7982eb1461f9"),
                            Name = "Сливен",
                            Postcode = "8800"
                        },
                        new
                        {
                            Id = new Guid("53625c71-1ef0-46e8-8d53-bc0e9b489435"),
                            Name = "Смолян",
                            Postcode = "4700"
                        },
                        new
                        {
                            Id = new Guid("62805889-e5f1-4947-b61c-fec7f720ba01"),
                            Name = "Стара Загора",
                            Postcode = "6000"
                        },
                        new
                        {
                            Id = new Guid("e3d7c9c5-f3ba-48da-8a76-68a796caa452"),
                            Name = "Хасково",
                            Postcode = "6300"
                        },
                        new
                        {
                            Id = new Guid("e7b7ddcb-9bd7-4b88-a6de-7b2d2fd7339b"),
                            Name = "Банско",
                            Postcode = "2770"
                        },
                        new
                        {
                            Id = new Guid("113f3e0a-3637-41a5-94be-4d3090033f81"),
                            Name = "Мелник",
                            Postcode = "2820"
                        },
                        new
                        {
                            Id = new Guid("05c03c8e-7ebb-419c-b5f7-018c6c9f81ee"),
                            Name = "Сандански",
                            Postcode = "2800"
                        },
                        new
                        {
                            Id = new Guid("dcfc7ddd-0510-44c6-955a-89dc46ca8c46"),
                            Name = "Симитли",
                            Postcode = "2730"
                        },
                        new
                        {
                            Id = new Guid("f25358be-9288-49a2-980b-2980706af30e"),
                            Name = "Айтос",
                            Postcode = "8500"
                        },
                        new
                        {
                            Id = new Guid("00dd7585-f941-4fb8-ac50-526b5af45d46"),
                            Name = "Ахелой",
                            Postcode = "8217"
                        },
                        new
                        {
                            Id = new Guid("9925fa4b-7576-45fe-832c-50d091bb75aa"),
                            Name = "Балчик",
                            Postcode = "9600"
                        },
                        new
                        {
                            Id = new Guid("c008e077-0626-40ac-953c-5d46577d4130"),
                            Name = "Банкя",
                            Postcode = "1320"
                        },
                        new
                        {
                            Id = new Guid("c2327b02-0fdd-4fe7-8ee9-db458ec3341d"),
                            Name = "Баня",
                            Postcode = "4360"
                        },
                        new
                        {
                            Id = new Guid("8c60bd4e-95b4-426b-aae5-015f3ca328bd"),
                            Name = "Белоградчик",
                            Postcode = "3900"
                        },
                        new
                        {
                            Id = new Guid("45d8aade-f6b3-475b-8bc1-a44bd3e0cd6e"),
                            Name = "Бяла",
                            Postcode = "9101"
                        },
                        new
                        {
                            Id = new Guid("4d161825-4adb-4cce-a91c-9be544090bf4"),
                            Name = "Велинград",
                            Postcode = "4600"
                        },
                        new
                        {
                            Id = new Guid("21747eea-acae-498e-b82e-a857e73d0361"),
                            Name = "Доспат",
                            Postcode = "4831"
                        },
                        new
                        {
                            Id = new Guid("bd8635c4-8199-41ca-ae7c-7948680937c0"),
                            Name = "Дряново",
                            Postcode = "5370"
                        },
                        new
                        {
                            Id = new Guid("9248020e-c2c1-417b-89c4-3c15ccaa5338"),
                            Name = "Елхово",
                            Postcode = "8700"
                        },
                        new
                        {
                            Id = new Guid("570fe0ae-35fc-42ee-a900-523a281480a2"),
                            Name = "Казанлък",
                            Postcode = "6100"
                        },
                        new
                        {
                            Id = new Guid("68db359c-b4e2-47ec-a29b-1acbf089181e"),
                            Name = "Калофер",
                            Postcode = "4370"
                        },
                        new
                        {
                            Id = new Guid("38b9d780-d0be-46c9-8c94-bebb6e24a6ac"),
                            Name = "Карлово",
                            Postcode = "4300"
                        },
                        new
                        {
                            Id = new Guid("d0751080-bd37-487f-9001-c9754589ddd8"),
                            Name = "Китен",
                            Postcode = "8183"
                        },
                        new
                        {
                            Id = new Guid("603abeb0-9b77-4700-a1ab-188f755cbe04"),
                            Name = "Клисура",
                            Postcode = "4341"
                        },
                        new
                        {
                            Id = new Guid("6d370c7c-30b8-4713-aa17-39f9d5a985a5"),
                            Name = "Копривщица",
                            Postcode = "2077"
                        },
                        new
                        {
                            Id = new Guid("74ead51e-65f9-4955-9067-88a2399c3cda"),
                            Name = "Лом",
                            Postcode = "3600"
                        },
                        new
                        {
                            Id = new Guid("d16ca82f-9448-4387-a3bb-0d790c3ef12a"),
                            Name = "Несебър",
                            Postcode = "8230"
                        },
                        new
                        {
                            Id = new Guid("01f8135e-3d86-441f-a072-bbc416fef625"),
                            Name = "Нова Загора",
                            Postcode = "8900"
                        },
                        new
                        {
                            Id = new Guid("c632ad7a-9aff-4c9c-80e2-5062d0822ef2"),
                            Name = "Обзор",
                            Postcode = "8250"
                        },
                        new
                        {
                            Id = new Guid("d55d59e8-5b05-415d-ad83-2b82879178ce"),
                            Name = "Павел Баня",
                            Postcode = "6155"
                        },
                        new
                        {
                            Id = new Guid("70137a2b-741e-44fd-84a1-b2f96096e211"),
                            Name = "Панагюрище",
                            Postcode = "4500"
                        },
                        new
                        {
                            Id = new Guid("c2c3a41a-d575-4455-8acc-4ab023a63faf"),
                            Name = "Петрич",
                            Postcode = "2850"
                        },
                        new
                        {
                            Id = new Guid("849f5fe9-4746-4333-9c97-7466e0a9c52d"),
                            Name = "Плиска",
                            Postcode = "9920"
                        },
                        new
                        {
                            Id = new Guid("c0e9889d-d8ee-4bff-a956-6bbd04c4d5ad"),
                            Name = "Самоков",
                            Postcode = "2000"
                        },
                        new
                        {
                            Id = new Guid("359fb370-c72f-4ab8-80f1-6b6727cce740"),
                            Name = "Сапарева баня",
                            Postcode = "2650"
                        },
                        new
                        {
                            Id = new Guid("ebc56ac2-6ea4-43b3-972c-e3d64b26d81a"),
                            Name = "Свети власт",
                            Postcode = "8256"
                        },
                        new
                        {
                            Id = new Guid("b7780b1c-d935-4ef5-a676-1189450e6f94"),
                            Name = "Созопол",
                            Postcode = "8130"
                        },
                        new
                        {
                            Id = new Guid("3064e2eb-23df-421b-8abd-344b53b462e1"),
                            Name = "Троян",
                            Postcode = "5600"
                        },
                        new
                        {
                            Id = new Guid("da3faa21-f5ee-448f-8ada-9cc78a7b1dc4"),
                            Name = "Трявна",
                            Postcode = "5350"
                        },
                        new
                        {
                            Id = new Guid("0c95c877-3a09-4edd-ad41-4b4df2d41ea8"),
                            Name = "Хисаря",
                            Postcode = "4180"
                        },
                        new
                        {
                            Id = new Guid("9fc986ec-e1cc-45b3-b461-e1d84e0b9d33"),
                            Name = "Боровец",
                            Postcode = "2010"
                        },
                        new
                        {
                            Id = new Guid("2d7b6a5b-36c8-448e-8378-cc3c5395a74a"),
                            Name = "Пампорово",
                            Postcode = "4870"
                        });
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Landmark", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Landmarks");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Guests")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.ReservationUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "ReservationId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationUser");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Resort", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stars")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Resorts");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Bathrooms")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Bedrooms")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PricePerNight")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ResortId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ResortId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.RoomReservation", b =>
                {
                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReservationId", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomReservation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Image", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Entities.Room", "Room")
                        .WithMany("Images")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Landmark", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Entities.City", "City")
                        .WithMany("Landmarks")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.ReservationUser", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Entities.Reservation", "Reservation")
                        .WithMany("ReservationUsers")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Резервирай_Преживяване.Data.Account.User", "User")
                        .WithMany("ReservationUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Resort", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Entities.City", "City")
                        .WithMany("Resorts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Room", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Entities.Resort", "Resort")
                        .WithMany("Rooms")
                        .HasForeignKey("ResortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resort");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.RoomReservation", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Entities.Reservation", "Reservation")
                        .WithMany("RoomReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Резервирай_Преживяване.Data.Entities.Room", "Room")
                        .WithMany("RoomReservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Account.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Account.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Резервирай_Преживяване.Data.Account.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Резервирай_Преживяване.Data.Account.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Account.User", b =>
                {
                    b.Navigation("ReservationUsers");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.City", b =>
                {
                    b.Navigation("Landmarks");

                    b.Navigation("Resorts");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Reservation", b =>
                {
                    b.Navigation("ReservationUsers");

                    b.Navigation("RoomReservations");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Resort", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Резервирай_Преживяване.Data.Entities.Room", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("RoomReservations");
                });
#pragma warning restore 612, 618
        }
    }
}
