using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class bayview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6c5683e1-cdbb-469f-964b-d34569919480", "a92fb410-ea56-4c6d-be13-9f6c7e2a0fd8", "Lower East Side", "LOWER EAST SIDE" },
                    { "97aa893c-fd5e-4f38-ae49-994be9a51114", "8b37de0c-3972-4130-8169-41b03818c771", "River West", "RIVER WEST" },
                    { "6311319b-fe14-4aaa-ab1d-f0f4f3096ea6", "0765d517-69cb-4571-9053-7b3fa7ed9ee0", "Downtown", "DOWNTOWN" },
                    { "2828396a-bf18-4ed2-b272-cc0483ed4de6", "8c753a75-bdd1-4a5e-be96-035b33f7a333", "Brewer's Hill", "BREWER'S HILL" },
                    { "b454c659-1920-4e84-9782-be6ffd79bed1", "3292a810-01c3-4744-8d4b-c6e1eb1b57e0", "Franklin Heights", "FRANKLIN HEIGHTS" },
                    { "a01a6771-ddfb-4a0f-8b00-7d578177c50f", "8f7b7655-99b4-45a0-b3d6-aa0098236fda", "Third Ward", "THIRD WARD" },
                    { "00e074ec-7351-4437-8db3-1e7c36df5c45", "d08dceee-4832-445b-9d4c-4a855176508a", "Walker's Point", "WALKER'S POINT" },
                    { "642b723c-b2d3-4056-a422-d70f0cb5fb48", "03919c8b-6f43-4476-99cf-aa22a0dc0035", "Story Hill", "STORY HILL" },
                    { "d633e0fd-c503-4c02-8103-a85a6b0ea5cb", "0fc55c2b-9586-4ff8-a2ae-a3246a80a7e7", "Washington Heights", "WASHINGTON HEIGHTS" },
                    { "16d6e7b8-6adc-422f-b6a9-7c08259e82be", "939afeea-511b-416c-9be7-57d95913bf42", "Bay View", "BAY VIEW" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00e074ec-7351-4437-8db3-1e7c36df5c45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16d6e7b8-6adc-422f-b6a9-7c08259e82be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2828396a-bf18-4ed2-b272-cc0483ed4de6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6311319b-fe14-4aaa-ab1d-f0f4f3096ea6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "642b723c-b2d3-4056-a422-d70f0cb5fb48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c5683e1-cdbb-469f-964b-d34569919480");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97aa893c-fd5e-4f38-ae49-994be9a51114");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a01a6771-ddfb-4a0f-8b00-7d578177c50f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b454c659-1920-4e84-9782-be6ffd79bed1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d633e0fd-c503-4c02-8103-a85a6b0ea5cb");

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
    }
}
