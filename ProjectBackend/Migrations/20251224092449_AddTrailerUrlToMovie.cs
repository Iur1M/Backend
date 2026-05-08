using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddTrailerUrlToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrailerUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/6hB3S9bIaco");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/sY1S34973zA");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/EXeTwQWrcwY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/s7EdQ4FqbhY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/r5X-hFf6Bwo");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/bLvqoHBptjg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/SUXWAEX2jlg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/YoHD9XEInc0");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/vKQi3bBA1y8");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/qo5jJpHtI1Y");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/znmZoVkCjpI");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/zSWdZVtXT7E");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/W6Mm8Sbe__o");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/9CiW_DgxCnQ");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/dcUOO4Itgmw");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/Ki4haFrqSrw");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/SEUXfv87Wpk");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/jawVxq1Iyl0");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/owK1qxDselE");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/7d_jQycdQGo");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/ijXruSzfGEc");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/iojhqm0JTW4");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/7TavVZMewpY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/CRRlbK5w8AE");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/qvsgGtivCgs");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/LjLamj-b0I8");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/u_jE7-6Uv7E");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/XfQYHqsiN5g");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/oiXdPolca5w");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/W5MTdkj5c-Q");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/NG3-GlvKPcg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/zAGVQLHvwOY");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/6ZfuNTqbHE8");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/TcMBFSGVi1c");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/1NJO0jxBtMo");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/iszwuX1AK6A");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/0fUCuvNlOCg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/KnrRy6kSFF0");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/gCcx85zbxz4");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/lB95KLmpLR4");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/LoebZZ8K5N0");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/aS_d0Ayjw4o");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/5iaYLCiq5RM");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/GokKUqLcvD8");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/Div0iP65aZo");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/hEJnMQG9ev8");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/dlnmQbPGuls");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/cd-go0oBF4Y");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/38A__WT3-o0");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/FeSLPELpMeM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrailerUrl",
                table: "Movies");
        }
    }
}
