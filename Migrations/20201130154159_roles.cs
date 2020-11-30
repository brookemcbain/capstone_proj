//using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32b1d63-3daa-4f6d-a5bc-6c57f4a6dbc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecff7750-89d8-47dc-8092-1eb902ba4d21");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4477ebe3-5119-492f-970e-b59934151cc3", "453e36d0-56bc-416a-b3c3-4b279a2235bb", "Lower East Side", "LOWER EAST SIDE" },
                    { "8ad5c615-b244-4395-bfea-785a95b2a2fc", "3e51506f-2ce9-44eb-8335-12a4a5fc630f", "River West", "RIVER WEST" },
                    { "8bde661e-d7d8-4b7e-a770-1f68ecae52ed", "5a5911f8-cc9b-40bc-bbc7-59f113960295", "Downtown", "DOWNTOWN" },
                    { "d026231d-71a9-4f2f-9afb-bbcf2ed40bdc", "b0f165f1-ea4b-4cfd-82b9-1dfb84992830", "Brewer's Hill", "BREWER'S HILL" },
                    { "97c9ecf4-f9d6-4a73-861d-a0205ac6c0bd", "a1ead94e-5b99-4736-848b-f7d9b312662c", "Franklin Heights", "FRANKLIN HEIGHTS" },
                    { "4c57ccaa-b4ac-4eec-be13-f5ec05e2d9bb", "3d6a1950-cf48-4ef1-9044-6c5096fd17b9", "Third Ward", "THIRD WARD" },
                    { "e0f96a47-7ff5-426a-82fd-10f427239619", "4f3a472b-6da9-41db-a5f0-1517a07c9b8a", "Walker's Point", "WALKER'S POINT" },
                    { "d92089e9-5691-4818-a949-12f89749cd42", "19ef9dde-ddc5-4f78-a535-caf63449c7c0", "Story Hill", "STORY HILL" },
                    { "7fad6521-5502-423e-9612-2b8d789faa8a", "837344f5-6738-4ab0-a3ce-8b38ff481709", "Washington Heights", "WASHINGTON HEIGHTS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4477ebe3-5119-492f-970e-b59934151cc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c57ccaa-b4ac-4eec-be13-f5ec05e2d9bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fad6521-5502-423e-9612-2b8d789faa8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ad5c615-b244-4395-bfea-785a95b2a2fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bde661e-d7d8-4b7e-a770-1f68ecae52ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97c9ecf4-f9d6-4a73-861d-a0205ac6c0bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d026231d-71a9-4f2f-9afb-bbcf2ed40bdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d92089e9-5691-4818-a949-12f89749cd42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0f96a47-7ff5-426a-82fd-10f427239619");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecff7750-89d8-47dc-8092-1eb902ba4d21", "55c4944d-d604-4e09-90ba-7f59dad03391", "Neighbor", "NEIGHBOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c32b1d63-3daa-4f6d-a5bc-6c57f4a6dbc6", "a58fcbbe-d8ca-405e-909a-16505a89c552", "Employee", "EMPLOYEE" });
        }
    }
}
