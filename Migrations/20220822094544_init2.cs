using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopSeminar.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4150e0ff-f3f5-4ea6-96ad-c43692cebc5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06db757f-625b-4bb9-8996-08be4477fa1c", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3", "cdee7e5e-6e95-46ea-99e9-9675eb406fab", "BasicUser", "BASICUSER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03bc7be8-1502-491d-a9f9-383c590dc428", new DateTime(2022, 8, 22, 11, 45, 43, 664, DateTimeKind.Local).AddTicks(2480), "AQAAAAEAACcQAAAAEP26yfI09MZopd9vutPoz3LJS16RomAKJmWNQ8rL9uwgHhff2nTy/AuDgcCkHkTboQ==", "097f3e8d-9f34-4ad9-b229-978067736140" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640e3f98-4203-4edf-8009-eb46168ad58d", new DateTime(2022, 8, 22, 11, 45, 43, 670, DateTimeKind.Local).AddTicks(4193), "AQAAAAEAACcQAAAAEDw+x8PrdzF+MBNS9a2BzUm1pQBSx1O7gx080WR9zLUk64hLB7aMDV62d5dG0ck6HQ==", "8af16470-0725-46b6-9c73-5ef426395dcc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "02023917-9b1f-46dc-a748-09227786c8b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50b3d9b1-58c8-493a-b5ba-e4ccaef0e2ac", "BasicUser", "BASICUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4", "52ccd265-c1cf-4d29-80c1-1ab7e1a0e2b5", "Editor", "EDITOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cd34c55-c9b4-4ca1-8593-2b112628f3b3", new DateTime(2022, 8, 22, 8, 10, 46, 927, DateTimeKind.Local).AddTicks(3816), "AQAAAAEAACcQAAAAEJ/xPFZukxm6xLm+dCZo31OdJFPH5t3LlP8voL9Pl/mc/wS8AcuF8i2vYtfLtQgvZw==", "be1b302b-a864-439d-a9a8-234f57b8f672" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6014e51e-1778-440a-9de0-5f0eb1776e7d", new DateTime(2022, 8, 22, 8, 10, 46, 933, DateTimeKind.Local).AddTicks(7567), "AQAAAAEAACcQAAAAEBtv4qK0uDz2CUKlMpp7VXeyHuKBrYAj7RyKGrf+gc+gJabJN9MhtWJDEiY5WAp+Ww==", "1b25ee1b-a548-41fd-a136-166b807df627" });
        }
    }
}
