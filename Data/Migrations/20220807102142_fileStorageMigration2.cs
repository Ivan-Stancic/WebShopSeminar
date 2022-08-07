using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopSeminar.Data.Migrations
{
    public partial class fileStorageMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DownloadUrl",
                table: "FileStorage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "FileStorage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "FileStorage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DownloadUrl",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "FileStorage");
        }
    }
}
