using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopSeminar.Data.Migrations
{
    public partial class shoppingChartItemMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Address",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ShoppingChart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingChart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingChart_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingChartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShoppingChartId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingChartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingChartItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingChartItem_ShoppingChart_ShoppingChartId",
                        column: x => x.ShoppingChartId,
                        principalTable: "ShoppingChart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingChart_ApplicationUserId",
                table: "ShoppingChart",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingChartItem_ProductId",
                table: "ShoppingChartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingChartItem_ShoppingChartId",
                table: "ShoppingChartItem",
                column: "ShoppingChartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingChartItem");

            migrationBuilder.DropTable(
                name: "ShoppingChart");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Address");
        }
    }
}
