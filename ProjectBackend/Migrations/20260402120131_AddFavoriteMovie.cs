using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddFavoriteMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FavoriteMovieId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FavoriteMovieId",
                table: "AspNetUsers",
                column: "FavoriteMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Movies_FavoriteMovieId",
                table: "AspNetUsers",
                column: "FavoriteMovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Movies_FavoriteMovieId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FavoriteMovieId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavoriteMovieId",
                table: "AspNetUsers");
        }
    }
}
