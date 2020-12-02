using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class newviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19f0ddd3-7f76-48b0-b511-c6c77118655d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e3975dd-6977-4767-8b15-bf88bf877f30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5472dfb0-1f68-4b32-9a26-aacc6761ce9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f5bafcf-1266-4050-8761-c151390288c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77694620-c9e6-4da1-a8fe-d771b414ace0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "938c7629-0437-4373-990d-c64d85d5cfbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d0bf18a-69fa-4476-acbb-2008d8388d0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57b893c-807b-4f73-8061-8619bf1c576c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfe09aa0-6981-4e1b-903c-dba6dfc23258");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3f62423-f322-4e9b-8c31-533756d48b10");

            migrationBuilder.AddColumn<int>(
                name: "ForumId",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Forum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Reply = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forum", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cd54eb63-74b9-4ee9-a489-466c515e384e", "6f380f6c-f846-4d5a-8491-0663629c98d7", "Lower East Side", "LOWER EAST SIDE" },
                    { "2e51e1ba-6412-4b5a-81cf-54f17f4d99cb", "07d14946-3ec8-4dd2-bd43-924997ee9655", "River West", "RIVER WEST" },
                    { "20ffaa05-000b-43bd-b1fb-5fef9e18625b", "064ecc9b-f197-4548-9996-e1ceaa4e4596", "Downtown", "DOWNTOWN" },
                    { "3204314a-597b-4fdd-9b1b-0841aa7fb91a", "693fb664-2191-44c6-baee-b2db850b9f6d", "Brewer's Hill", "BREWER'S HILL" },
                    { "11861045-dfc3-48e0-a6b9-e5eb94aa1403", "98cc94f6-adf3-40e1-8eee-bc8638d64592", "Franklin Heights", "FRANKLIN HEIGHTS" },
                    { "1e250c55-dcbe-4cd2-9439-d4115357a36a", "3cf9dc87-fc08-4d5c-ab42-2738810f422e", "Third Ward", "THIRD WARD" },
                    { "1513f03c-1824-4fa6-90ad-b6bad1f1f4b4", "6a73fdd6-ed64-4e06-8e43-cc911ccff7e5", "Walker's Point", "WALKER'S POINT" },
                    { "dfc71806-8929-4d1b-8637-e1de1896910c", "c61b3436-71cc-42e5-9363-886a4fc0840b", "Story Hill", "STORY HILL" },
                    { "ab609ac8-5785-4a52-beff-427e7c5ec274", "5b762c9d-e9a1-4a58-85cb-4d9ac9b5f6a5", "Washington Heights", "WASHINGTON HEIGHTS" },
                    { "259026e8-160d-48de-887a-118b0678ad32", "40e0b1ea-e351-4cf9-a549-794ee9177c04", "Bay View", "BAY VIEW" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ForumId",
                table: "Posts",
                column: "ForumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Forum_ForumId",
                table: "Posts",
                column: "ForumId",
                principalTable: "Forum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Forum_ForumId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Forum");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ForumId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11861045-dfc3-48e0-a6b9-e5eb94aa1403");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1513f03c-1824-4fa6-90ad-b6bad1f1f4b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e250c55-dcbe-4cd2-9439-d4115357a36a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20ffaa05-000b-43bd-b1fb-5fef9e18625b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "259026e8-160d-48de-887a-118b0678ad32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e51e1ba-6412-4b5a-81cf-54f17f4d99cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3204314a-597b-4fdd-9b1b-0841aa7fb91a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab609ac8-5785-4a52-beff-427e7c5ec274");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd54eb63-74b9-4ee9-a489-466c515e384e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc71806-8929-4d1b-8637-e1de1896910c");

            migrationBuilder.DropColumn(
                name: "ForumId",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e3975dd-6977-4767-8b15-bf88bf877f30", "c30b8e33-de2f-41e5-9a04-045c3ff032e2", "Lower East Side", "LOWER EAST SIDE" },
                    { "5472dfb0-1f68-4b32-9a26-aacc6761ce9d", "2fb748d6-4601-4fba-b486-313a4d868d9c", "River West", "RIVER WEST" },
                    { "d57b893c-807b-4f73-8061-8619bf1c576c", "21075567-ab7a-4b2c-b37a-49a659052aed", "Downtown", "DOWNTOWN" },
                    { "9d0bf18a-69fa-4476-acbb-2008d8388d0d", "1bc870f6-ac1b-49dc-9ef7-8076fac1efe8", "Brewer's Hill", "BREWER'S HILL" },
                    { "19f0ddd3-7f76-48b0-b511-c6c77118655d", "2136a601-51b1-46a8-be1e-8c6fa8d6c407", "Franklin Heights", "FRANKLIN HEIGHTS" },
                    { "dfe09aa0-6981-4e1b-903c-dba6dfc23258", "23b6ffe1-f43f-441e-a33a-7ff577455c0c", "Third Ward", "THIRD WARD" },
                    { "77694620-c9e6-4da1-a8fe-d771b414ace0", "e1f07859-bb31-41d6-b8b9-6cba4e3d56a3", "Walker's Point", "WALKER'S POINT" },
                    { "938c7629-0437-4373-990d-c64d85d5cfbe", "f99bac10-555c-4ca7-bc1c-64c09dde1305", "Story Hill", "STORY HILL" },
                    { "5f5bafcf-1266-4050-8761-c151390288c9", "c381fe42-2c64-4488-9fbe-ab150ec83850", "Washington Heights", "WASHINGTON HEIGHTS" },
                    { "f3f62423-f322-4e9b-8c31-533756d48b10", "84b9f7e5-797d-4278-9da6-a4327718c2f4", "Bay View", "BAY VIEW" }
                });
        }
    }
}
