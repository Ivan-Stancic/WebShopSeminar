using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopSeminar.Data.Migrations
{
    public partial class proizvodiMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c7d3d230-3198-4057-a0b7-f40ac2bf3b58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "22f95358-b575-4c27-89cf-46b5079fe0ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "276993d0-cc9e-4b63-84a6-03ed15fe5aad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4e75c9-98cf-48ea-b5ed-b22b91d5f528", "AQAAAAEAACcQAAAAEJuT9dI7EDQi0A6RywW6ofsEnMv0DpktXKjHdu3e2WQKX3rJEKlM+LOxy7RFhC992A==", "9fdebac6-2cd3-4a0b-8565-00055e1926ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1d1aabe-a66f-4a87-8bb1-8a65d0418432", "AQAAAAEAACcQAAAAEAsvG86R7V+NzW4rQjNN5E//+FPDzv7fEwXwsJ2Dl/GD6R10K31lUe2P/2CfEIgB9g==", "4c3f24f5-4032-4ee8-b435-b1779e7a0e2d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductImgUrl",
                value: "https://www.novilist.hr/wp-content/uploads/2021/04/balcony-200431_1280.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductImgUrl",
                value: "https://image.dnevnik.hr/media/images/1600x1067/May2022/62305330-alpake.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductImgUrl",
                value: "https://www.tportal.hr/media/thumbnail/w1000/182058.jpeg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductImgUrl",
                value: "https://magic-croatia.hr/wp-content/uploads/2021/05/boat-tour-zadar-telascica-nature-park-870x555.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductImgUrl",
                value: "https://upload.wikimedia.org/wikipedia/hr/thumb/5/54/Vino.jpg/800px-Vino.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductImgUrl",
                value: "https://static.jutarnji.hr/images/slike/2022/01/08/23256043.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductImgUrl",
                value: "https://zivotnimagazin.com/wp-content/uploads/2018/03/vikendica-iz-bajke-2.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductImgUrl",
                value: "https://i.ytimg.com/vi/jL083wMBMlM/maxresdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductImgUrl",
                value: "https://www.tportal.hr/media/thumbnail/w1000/1452357.jpeg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductImgUrl",
                value: "https://gospodarski.hr/wp-content/uploads/2019/04/Krekeri.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductImgUrl",
                value: "https://www.purina.hr/sites/default/files/2017-11/the-big-outdoors.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f4a6a3e7-3c8d-424d-8107-3210282b8e3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d67af28d-18c6-46f6-93cf-2e05be75997d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "3bf88e5c-c1a9-4730-9a6a-619eb328d323");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f551be21-c197-4e06-af85-aa578260c8b2", "AQAAAAEAACcQAAAAEHf9GbfQOl2DoGLvVFHAWJAgfJNcrqa2P+UUQk8XUWX2zNqfc9u03lr9odVWfb5kVA==", "b9a3e8a1-c6b9-443b-b36b-fbf3adacaaec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9db0032-86be-45af-a15c-3dc0cb9be0c1", "AQAAAAEAACcQAAAAEGK3lYnPLpHi+RAzh+HJ3p6B92ss5iSvXZYhJa+PCLOsfnvI2BdyEHHSzV84EcFHQQ==", "24d22df3-94be-444f-8476-d090383c859a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductImgUrl",
                value: "U");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductImgUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductImgUrl",
                value: "");
        }
    }
}
