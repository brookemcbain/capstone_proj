using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "880501c1-7c16-4943-a8f6-1d0887bf3fbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0ce7816-f43c-4a92-84ef-ec7757540c8f");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpotID",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    OwnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eb9405dc-0de1-4c4e-a4b4-50c8ab89dae9", "8e725cd6-67fe-41b9-9772-f6237d7d0e0b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "256265ac-33a3-4093-ae29-d4f3391dd0a9", "1990dcd6-3083-4478-a261-6f6938d20b7a", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_LocationID",
                table: "Customer",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Location_LocationID",
                table: "Customer",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Location_LocationID",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Customer_LocationID",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "256265ac-33a3-4093-ae29-d4f3391dd0a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9405dc-0de1-4c4e-a4b4-50c8ab89dae9");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SpotID",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "880501c1-7c16-4943-a8f6-1d0887bf3fbe", "4dac9ba1-5edd-4a6f-8a86-a242fd3cffff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0ce7816-f43c-4a92-84ef-ec7757540c8f", "32a0d7ba-d7f7-4afc-aee4-984bf73dd310", "Employee", "EMPLOYEE" });
        }
    }
}
