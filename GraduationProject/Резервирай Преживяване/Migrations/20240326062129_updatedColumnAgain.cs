using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class updatedColumnAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "2a623e37-0793-4583-9838-56a82146ec2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "92b328ef-e3ff-4e44-a5d7-7d29c73d6463");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd04b78b-9a60-4ef4-a98d-4e8e0341e88b", "AQAAAAEAACcQAAAAENGppRLctnKRzKMEnLfco4q5ZN1/CnA1jcuFp2ZVkvgnAKmaNZLI5zv3MGVtKvMSmA==", "e0cad4ad-b774-4d44-abec-1632c2842660" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69535d6b-a065-4b3c-b2a9-2da7d8338bd3", "AQAAAAEAACcQAAAAEPtal8pA3jkCWrdRrN/Ym9R0IboAA6h5OxOAl3oXzzTtsIfYshI/A+SNW0kKihdi3Q==", "4862fec3-d3cc-4e67-9ee4-009eb4417a25" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTaken",
                table: "Rooms");

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
    }
}
