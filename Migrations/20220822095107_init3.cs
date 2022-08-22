using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopSeminar.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "cf7df5b4-a388-401d-82f1-1ed2f54a135a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0bfeb7e6-56ad-41db-a83a-1d39f3df3635");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f755027e-c88d-4919-9681-70e73822bb72");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e1e150c-4d07-48a7-a58b-21bbd85ac8b6", new DateTime(2022, 8, 22, 11, 51, 6, 558, DateTimeKind.Local).AddTicks(6261), "AQAAAAEAACcQAAAAEO7g1iODTgfZDdKLIGUS808itY2+O1Vaxlf8+W4nkzzH1CzMs9mNYJOJyAXo5qZgbw==", "6b669d0e-8a8c-4a1b-8009-446595df69ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e762c27-c5b7-4c53-bce8-54cc1277d6a4", new DateTime(2022, 8, 22, 11, 51, 6, 564, DateTimeKind.Local).AddTicks(7726), "AQAAAAEAACcQAAAAEGgQHqXkI76Oe12GSs3U/NOTUDqAXizdWdcuAikGeQ+RX8onyhnOsj4BEa99s7M1qA==", "b1ad45fc-6c81-46df-864b-09eb5ef639e3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2" });

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
                column: "ConcurrencyStamp",
                value: "06db757f-625b-4bb9-8996-08be4477fa1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cdee7e5e-6e95-46ea-99e9-9675eb406fab");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });

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
    }
}
