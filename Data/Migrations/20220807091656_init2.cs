using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopSeminar.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductImgUrl",
                table: "ProductViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductImgUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImgUrl",
                table: "ProductViewModel");

            migrationBuilder.DropColumn(
                name: "ProductImgUrl",
                table: "Product");
        }
    }
}
