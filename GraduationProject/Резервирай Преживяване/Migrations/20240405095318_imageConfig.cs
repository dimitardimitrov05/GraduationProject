using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class imageConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "75e3155c-40d5-4dca-b1f1-2a5bf7bd8ff8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "957a4be5-a643-47c9-8699-d44f9b679c1b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b8ddbb-106b-4972-94ea-9b4139d62d9d", "AQAAAAEAACcQAAAAELAzyIuwreWLd0RJUcUntYKjxMitql0E2kEQgRcZow89HqDQkBbYRnUYrJ/ijBxCNw==", "771f34a1-0d0b-48af-bd34-75b86549d4ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c20bbaf-f992-4166-9dec-6937159e84f8", "AQAAAAEAACcQAAAAEG9UN3MsIwofvVDuf4oktJQFSHQzBAodbJFdIpP3MCElNYGGzYkVZtvGG2BWpIfMPw==", "b57a325e-faac-4c32-a807-0d646d355990" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "RoomId", "Url" },
                values: new object[] { new Guid("5636c8c3-d55a-4bfc-8427-6423e387259b"), new Guid("5448199b-bbcf-4ea5-a120-417ca95a5933"), "https://cf.bstatic.com/xdata/images/hotel/max1024x768/269595129.jpg?k=4510139b9a0b9d3cdd42fed45f0a6f932d2fe620ceee14014e69d2bab241a084&o=&hp=1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("5636c8c3-d55a-4bfc-8427-6423e387259b"));

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
        }
    }
}
