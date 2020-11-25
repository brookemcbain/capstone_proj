using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "256265ac-33a3-4093-ae29-d4f3391dd0a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9405dc-0de1-4c4e-a4b4-50c8ab89dae9");

            migrationBuilder.AddColumn<int>(
                name: "FirstName",
                table: "Location",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastName",
                table: "Location",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Neighbors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Community = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true),
                    SpotID = table.Column<int>(nullable: true),
                    LocationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighbors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Neighbors_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Neighbors_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4426b53e-9a09-410c-bf2e-3eb255b7716e", "7453b315-19b2-45c5-a9fd-553a6f2d536d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "681690b8-9535-40d6-8d2a-22d204922e23", "4242914e-838b-46bb-b749-55ab6fcedd92", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Neighbors_IdentityUserId",
                table: "Neighbors",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Neighbors_LocationID",
                table: "Neighbors",
                column: "LocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Neighbors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4426b53e-9a09-410c-bf2e-3eb255b7716e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "681690b8-9535-40d6-8d2a-22d204922e23");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Location");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpotID = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_LocationID",
                table: "Customer",
                column: "LocationID");
        }
    }
}
