using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class addtolostandfound : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "284580ae-4774-4e1c-a26d-b5022eeb2ac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a10dc48-cc7c-4593-94d8-321cd8282cb5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06f94aa1-4d01-465b-ae84-c49a8c328ee6", "b0a380f9-0f1a-4a90-a122-7250dd32941d", "Neighbor", "NEIGHBOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ba26779-fc18-4824-be62-aa0e94161d94", "e8ef26a0-d9db-410f-bea8-24a48d5f3fd9", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06f94aa1-4d01-465b-ae84-c49a8c328ee6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ba26779-fc18-4824-be62-aa0e94161d94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "284580ae-4774-4e1c-a26d-b5022eeb2ac1", "05480bd7-f4f4-4452-9509-72f938a6f96b", "Neighbor", "NEIGHBOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a10dc48-cc7c-4593-94d8-321cd8282cb5", "4625c499-979b-4ee1-a1ed-6a9b25a97ce3", "Employee", "EMPLOYEE" });
        }
    }
}
