using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class moreLandmarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "6c8f50b6-7d97-41fc-a324-3e73bf0f79f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "205b30bc-9552-45e2-9966-44524f8548f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ae6614a-1475-4de0-8521-ebca52e96cd5", "AQAAAAEAACcQAAAAEFSapwZcR0wRirtGxACoEAyACGKf+iInMwknj7iV0War2bnfmlh+cM4C3zl4KjRUSw==", "2d43c311-613c-4fd8-8e5e-05d3c3b123c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c4ad7f8-1e52-483c-b193-859a8994a0c8", "AQAAAAEAACcQAAAAEC8ESsWYN4foPQ8VOLoQpOFHSHBolppC53dDQmTJJteSCtn4SK8dLZ7zobEF6QZ1Eg==", "f7af3a93-bd6a-4af3-8a59-53f9dfb46ff2" });

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("236d2b5d-23f4-48e8-8c9a-20b6337058d6"), new Guid("9d1d0c7c-daa1-4941-91b4-db28a7da4e03"), "Морскaта грaдина е разположeна над централния плаж в централнaта чaст на Бургас. Площта на Морската градина е 600 декара. Старaта чaст на Морскaта грaдина е обявeна за памeтник на парковoто изкуство. Строежът й започва през 1910 година. През 1936 година е открит първият Бургaски мoст, а през 1938 гoдина е построeно Мoрското кaзино. В миналото в Морската градина е имaло Грaдски цветaрник, остъклeн кaто оранжeрия с екзoтични трoпични растeния. В Морската градина има Летен театър, други по-интересни обекти, които са разположени на територията на Морскaта грaдина са: Морско казино; Пантeона на загинaлите във войните; скулптори и бюстове на извeстни писaтели, актьoри и други; паметника на моряка и др.", "https://www.gotoburgas.com/uploads/property/36956fa95dea393ddcac08685515bc21.jpg", "Морската градина" },
                    { new Guid("32688fbb-ba73-495a-9acd-81a2848fe603"), new Guid("9d1d0c7c-daa1-4941-91b4-db28a7da4e03"), "Той обхваща над 180 възрожденски созополски къщи, строени между средата на XVIII и началото на XIX век, част от които са обявени за паметници на културата. В границите на резервата се намират още средновековната църква при манастира „Св. Апостоли“, Художествената галерия, Етнографската сбирка, църквата „Св. Богородица“, християнски средновековен комплекс, музеят при крепостната стена, църквата „Св. Георги“ с мощите на св. Йоан Кръстител. Архитектурата на созополската къща е специфична, като в нея има елементи и от странджанската, и от старопланинската възрожденска къща. Градена е с каменни основи и кирпичени стени, облечени с външна дървена обшивка, която пази сградата от соления морски вятър. Покривът е покрит с турски керемиди. Повечето стари созополски къщи са на два или три етажа, като първият е бил използван за стопански нужди и за съхранение на занаятчийски инструменти и на бъчви с вино. Най-популярните созополски къщи са тази на Мариета Стефанова, която е построена върху средновековната крепостна стена; къщата на Курдилис, в която днес се помещава Етнографският музей; къщата на баба Кукулиса Хаджиниколова; къщата на Куртиди, известна още като Тракийския хан, в която може да се види впечатляваща дърворезба в една от стаите на втория етаж; къщата на Лина Псарианова; къщата на Креаноолу и др. В Стария Созопол днес могат да се видят и реставрираните останки на южната крепостна стена с правоъгълна кула. Древният град е бил разположен на скалистия полуостров и е бил опасан от крепостни стени, които го пазели по море и по суша. Стените са били издигнати в началото на VI в. н.е., като са престроявани и доизграждани многократно след това. Днес в комплекса може да се види също квадратен древен кладенец от IV – III в. пр.Хр., част от водопровода на древния град, датиран от V в. пр.Хр., ранновизантийско зърнохранилище, параклис от XIII-XIV в. и др. На близкия остров Св. Иван през 2010 г. бяха открити мощи на св. Йоан Кръстител. Ценната реликва днес се пази в храма „Св. Георги” в Стария град и привлича хиляди поклонници от цял свят. Старият Созопол бе обявен за победител в класацията „Чудесата на България”, проведена през 2011 г.", "https://familytravelspirit.com/wp-content/uploads/2019/09/32-krepostnata-kula-na-sozopol.jpg", "Старият град Созопол" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("236d2b5d-23f4-48e8-8c9a-20b6337058d6"));

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("32688fbb-ba73-495a-9acd-81a2848fe603"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "fcca65fd-b9f9-4000-9514-b521b4450d04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "20b623ea-edb1-4774-8b66-551b3f53ce26");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3f0670f-8fd9-46fd-9b3e-3204c43430dd", "AQAAAAEAACcQAAAAEEEd7kfkvVQxHVkpuCLPkcwKjMv4EuYJ+lxAUOyN1aVPyMvmYsuT/6W5WNJhvqsZEw==", "b7246e24-e45b-4744-886c-e963efd3dbba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0fc70a9-8db3-43f2-bf5f-5953ba59ff4b", "AQAAAAEAACcQAAAAEGZDut/U/KyyMwld22owa6feXhYqd70MfgiwUtk43BjVLR25ZDn7RqH5AqZtGDqwaQ==", "aa308858-b789-4526-8eb9-1a593a2b9972" });
        }
    }
}
