using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class removeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTaken",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "e0fe79e9-d031-487c-8e63-a120e84aeee2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "9adc2420-0946-4f52-8f24-f9ead7ce4528");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12c07964-853c-4a56-9650-6389f800beb0", "AQAAAAEAACcQAAAAEP2eKIheJpAWXyWeCfvPs4EH/xT42cVUjQ/OwfK2LMN35TUHCb9xZAo9jaWxOBuDdQ==", "1cf1556d-9271-4d47-8473-ab4ae7cab1ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3788e178-7b19-4fac-9a0a-a503d4e3f8f3", "AQAAAAEAACcQAAAAEI/uj/fYLLc6Gh7fT9cYQiyT4CQ77YrsBHU3POd5wvCMLBee1/MFVRaAqJSJTifDRw==", "a4aa451f-c00b-4cf1-b0c3-0fe581224be5" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("14ceac29-39c3-482b-b0d7-ff163d408340"),
                column: "Name",
                value: "Белоградчишките скали");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTaken",
                table: "Rooms",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "5a101cd1-775f-4302-a5e6-a704244a6a86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "99a469ff-b3aa-4ea2-a0bd-6137e9db8ed3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2322a2b2-79a0-43ec-8b09-728d8eeb3b57", "AQAAAAEAACcQAAAAEOrd/1nK2nksuuZ+GB6vozrV4QmZREuQkwgYbg3FUevOGvjQyNovrAZLHJ7E9xZiOA==", "b96b757c-4d95-41c5-b87a-2cab00f7bd33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de26bb40-e17d-45ce-abeb-9c961240b0d9", "AQAAAAEAACcQAAAAEKmr6chLgxbPniX/mVM6c5WNvhpIowHpu680XTmJj8vNa8t79+bXBytAHR67lJdT/Q==", "4d90aa21-d5de-46ec-bfdc-72496851eed2" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("14ceac29-39c3-482b-b0d7-ff163d408340"),
                column: "Name",
                value: "Белографчишките скали");
        }
    }
}
