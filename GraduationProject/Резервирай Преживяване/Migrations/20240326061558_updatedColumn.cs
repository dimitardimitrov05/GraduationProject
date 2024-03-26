using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class updatedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Reservations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "f426a78e-e12f-4a5d-a9b8-267cfda4491e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "27416326-2828-4aa3-aac0-54d39a764e94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f00b96-e803-4c3b-8c69-6210ee554889", "AQAAAAEAACcQAAAAEKm2R1l3j9PbsiN+DowySaErxnmL5bR+sLt+L43wrPJqPxUNa5U6J6BEzifl31YbEQ==", "fa1cefab-1db3-40dd-acde-b91fa02f8201" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47fc69f5-4cf3-4109-8fa5-86a8a3cd216f", "AQAAAAEAACcQAAAAENfNpcTO1q22bk3Rd1vY3wsr64TJLjiP8/3Vm1b0uzuMxRN0SKMiEtMPCt7G/s5Bhw==", "171c1443-2aca-4c06-b6b5-b4a6be50d158" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "ab2a5b15-b1b7-43cf-a527-a3dc529a4226");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "dfe29b01-f9c3-4131-b1d2-d36605aeee8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05f60ff6-d966-4be8-9d85-96142733bfb2", "AQAAAAEAACcQAAAAEGhxpFe5tskdI5Q9UnYwqGxfbn7CVfzTO5TKa3yjeCyh3rBd11gCMQr2zrONlLqTqg==", "e6afe6d2-c43a-487a-9020-572f01f0e979" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9623b76-5d0f-4053-9971-ead95f49932a", "AQAAAAEAACcQAAAAELua7nrApLfnHXyDVJgpTn2UaCeDTklDFstZ9sB6cvj2vX+GBWzlWzsDJfAKMJWi2Q==", "3d3acb0e-d45b-4f44-ae4c-83b8d38057da" });
        }
    }
}
