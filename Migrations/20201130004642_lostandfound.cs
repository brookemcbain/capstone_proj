using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class lostandfound : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "101e09f2-9507-4d67-be77-02ab8daf90d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6af63957-d480-45fb-8d4b-a82146061109");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "284580ae-4774-4e1c-a26d-b5022eeb2ac1", "05480bd7-f4f4-4452-9509-72f938a6f96b", "Neighbor", "NEIGHBOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a10dc48-cc7c-4593-94d8-321cd8282cb5", "4625c499-979b-4ee1-a1ed-6a9b25a97ce3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "101e09f2-9507-4d67-be77-02ab8daf90d7", "6a723c73-2f39-42e9-a672-95276442ac47", "Neighbor", "NEIGHBOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6af63957-d480-45fb-8d4b-a82146061109", "c2248d34-f9ad-4cba-b583-96487e9dcda2", "Employee", "EMPLOYEE" });
        }
    }
}
