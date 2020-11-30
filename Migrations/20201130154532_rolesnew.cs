using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class rolesnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "153e867a-302a-4d5f-80e1-4b8381a7b300", "f6e2535d-fdd1-4d0e-ba58-c42b2c281061", "Lower East Side", "LOWER EAST SIDE" },
                    { "ba9bcc96-e2c9-4c97-9621-4e059ad8bf9b", "f9c636ec-74d2-4b17-84f8-94541e2c0426", "River West", "RIVER WEST" },
                    { "921a9834-aab1-4116-8e6c-c295866f2a55", "02e9d7b4-5f2a-42d6-a087-40212cbfc8db", "Downtown", "DOWNTOWN" },
                    { "923b980f-52d0-4ee6-befb-1c71e23d0546", "254347be-6d2f-4dbf-83cd-efa1db22d6b8", "Brewer's Hill", "BREWER'S HILL" },
                    { "f797de6a-b141-4813-958e-a89042bc3f22", "afffa9a7-39d2-41ca-a30b-eef5e21ec806", "Franklin Heights", "FRANKLIN HEIGHTS" },
                    { "f82474e4-ec29-4f28-b943-947b10aaee1e", "37e71229-69c7-467e-9316-569d2d3eb843", "Third Ward", "THIRD WARD" },
                    { "35d32bbd-ce3d-49b6-820b-912debf10f3f", "0bd44927-86da-4b4f-aaeb-cf5b9d1d712e", "Walker's Point", "WALKER'S POINT" },
                    { "2fe15904-e2cb-458d-b701-ce245027de4b", "7dfd6a8c-efff-49cb-aefb-78cad31df795", "Story Hill", "STORY HILL" },
                    { "559e4806-6a2f-48e2-b19a-b81782864a7d", "f8920057-5af6-409f-bc41-fecc5d20ee6d", "Washington Heights", "WASHINGTON HEIGHTS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "153e867a-302a-4d5f-80e1-4b8381a7b300");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fe15904-e2cb-458d-b701-ce245027de4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35d32bbd-ce3d-49b6-820b-912debf10f3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "559e4806-6a2f-48e2-b19a-b81782864a7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "921a9834-aab1-4116-8e6c-c295866f2a55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "923b980f-52d0-4ee6-befb-1c71e23d0546");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9bcc96-e2c9-4c97-9621-4e059ad8bf9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f797de6a-b141-4813-958e-a89042bc3f22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f82474e4-ec29-4f28-b943-947b10aaee1e");

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
    }
}
