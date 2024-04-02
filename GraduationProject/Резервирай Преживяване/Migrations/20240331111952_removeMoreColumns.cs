using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class removeMoreColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomCount",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "2026fdd3-199e-46fd-960a-6606526281a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "008acb85-c307-4df9-909f-1e7310314edd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18767715-63dc-4a87-af18-0ff6aaa130b6", "AQAAAAEAACcQAAAAEBAyHBlmrlHAbtWErBC+7+YFYCw1lRNPme88lyfWDNoPUiwZKYXObQDIdtfblI1OZw==", "515c8357-5513-46a5-816d-8f5afad0050e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abded4a-b010-4034-969e-9957d764578a", "AQAAAAEAACcQAAAAEDSfnPCSgKZARYFaT+UdLJsdnKo5w2vGtQKxHCHTosgWynroa+z1dXAmOy3kjKnYHg==", "00932138-55f1-4e7b-9662-59f057c1cc47" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomCount",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
