using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "PosterUrl", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Frank Darabont", "https://image.tmdb.org/t/p/original/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg", 9.3000001907348633, "The Shawshank Redemption", 1994 },
                    { 2, "Francis Ford Coppola", "https://image.tmdb.org/t/p/original/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", 9.1999998092651367, "The Godfather", 1972 },
                    { 3, "Christopher Nolan", "https://image.tmdb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg", 9.0, "The Dark Knight", 2008 },
                    { 4, "Quentin Tarantino", "https://image.tmdb.org/t/p/original/dM2w364MScsjFf8pfMbaWUcWrR.jpg", 8.8999996185302734, "Pulp Fiction", 1994 },
                    { 5, "Peter Jackson", "https://image.tmdb.org/t/p/original/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg", 8.8999996185302734, "The Lord of the Rings: The Return of the King", 2003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
