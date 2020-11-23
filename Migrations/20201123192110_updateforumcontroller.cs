using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class updateforumcontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b1a7e4-2f78-41ab-ad5b-538e83a522d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddac9366-e2bf-4d41-a316-5df7387e29b9");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Posts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9936d1e5-9786-46b2-88c3-221fc13a040c", "ef11820d-bd82-4357-b244-4a44a3752fcd", "Neighbor", "NEIGHBOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97159c5b-1a7c-4ad6-86ce-6fdc0cd89cdf", "2c30056c-e7e2-4f9c-b354-0f8fac553a6c", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_IdentityUserId",
                table: "Posts",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_IdentityUserId",
                table: "Posts",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_IdentityUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_IdentityUserId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97159c5b-1a7c-4ad6-86ce-6fdc0cd89cdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9936d1e5-9786-46b2-88c3-221fc13a040c");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ddac9366-e2bf-4d41-a316-5df7387e29b9", "85b61d3c-cee4-453e-af14-fb9f30e33c06", "Neighbor", "NEIGHBOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30b1a7e4-2f78-41ab-ad5b-538e83a522d9", "09f14d64-4117-4b40-b14e-bb17cfe349d1", "Employee", "EMPLOYEE" });
        }
    }
}
