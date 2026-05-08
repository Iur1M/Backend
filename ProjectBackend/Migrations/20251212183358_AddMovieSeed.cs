using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://m.media-amazon.com/images/I/51NiGlapXlL.jpg", 9.3000000000000007 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://m.media-amazon.com/images/I/41+eK8zBwQL.jpg", 9.1999999999999993 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51k0qa6zH-L.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SL1024_.jpg", 8.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg", 8.9000000000000004 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "PosterUrl", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 6, "Robert Zemeckis", "https://m.media-amazon.com/images/I/61+Kz2Rk6JL._AC_SL1000_.jpg", 8.8000000000000007, "Forrest Gump", 1994 },
                    { 7, "David Fincher", "https://m.media-amazon.com/images/I/71vV1SWnSUL._AC_SL1500_.jpg", 8.8000000000000007, "Fight Club", 1999 },
                    { 8, "Christopher Nolan", "https://m.media-amazon.com/images/I/51vbF7DheLL.jpg", 8.6999999999999993, "Inception", 2010 },
                    { 9, "The Wachowskis", "https://m.media-amazon.com/images/I/51EG732BV3L.jpg", 8.6999999999999993, "The Matrix", 1999 },
                    { 10, "Martin Scorsese", "https://m.media-amazon.com/images/I/51edC+FODKL.jpg", 8.6999999999999993, "Goodfellas", 1990 },
                    { 11, "David Fincher", "https://m.media-amazon.com/images/I/71rNJQ2g-QL._AC_SL1500_.jpg", 8.5999999999999996, "Seven", 1995 },
                    { 12, "Christopher Nolan", "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SL1500_.jpg", 8.5999999999999996, "Interstellar", 2014 },
                    { 13, "Jonathan Demme", "https://m.media-amazon.com/images/I/51WcRoWSQlL.jpg", 8.5999999999999996, "The Silence of the Lambs", 1991 },
                    { 14, "Steven Spielberg", "https://m.media-amazon.com/images/I/51P1n0Pp-rL.jpg", 8.5999999999999996, "Saving Private Ryan", 1998 },
                    { 15, "Fernando Meirelles", "https://m.media-amazon.com/images/I/51hYwc3%2BcbL.jpg", 8.5999999999999996, "City of God", 2002 },
                    { 16, "Frank Darabont", "https://m.media-amazon.com/images/I/51k0qa6zH-L.jpg", 8.5999999999999996, "The Green Mile", 1999 },
                    { 17, "Bong Joon-ho", "https://m.media-amazon.com/images/I/71cIkzdg86L._AC_SL1500_.jpg", 8.5, "Parasite", 2019 },
                    { 18, "Luc Besson", "https://m.media-amazon.com/images/I/51Vp5cv16fL.jpg", 8.5, "Leon: The Professional", 1994 },
                    { 19, "Ridley Scott", "https://m.media-amazon.com/images/I/51A7Q6Qac7L.jpg", 8.5, "Gladiator", 2000 },
                    { 20, "Damien Chazelle", "https://m.media-amazon.com/images/I/81VStYnDGrL._AC_SL1500_.jpg", 8.5, "Whiplash", 2014 },
                    { 21, "Christopher Nolan", "https://m.media-amazon.com/images/I/51Y-8jb8eVL.jpg", 8.5, "The Prestige", 2006 },
                    { 22, "Martin Scorsese", "https://m.media-amazon.com/images/I/51U1vgbuEoL.jpg", 8.5, "The Departed", 2006 },
                    { 23, "Roger Allers", "https://m.media-amazon.com/images/I/51XX-7bb2YL.jpg", 8.5, "The Lion King", 1994 },
                    { 24, "James Cameron", "https://m.media-amazon.com/images/I/51FzPxPV6mL.jpg", 8.5, "Terminator 2: Judgment Day", 1991 },
                    { 25, "Robert Zemeckis", "https://m.media-amazon.com/images/I/51T9V5W3uqL.jpg", 8.5, "Back to the Future", 1985 },
                    { 26, "Ridley Scott", "https://m.media-amazon.com/images/I/71VmOAX-HcL._AC_SL1500_.jpg", 8.5, "Alien", 1979 },
                    { 27, "Roman Polanski", "https://m.media-amazon.com/images/I/51DGiokwbrL.jpg", 8.5, "The Pianist", 2002 },
                    { 28, "Tony Kaye", "https://m.media-amazon.com/images/I/51w0nggYJTL.jpg", 8.5, "American History X", 1998 },
                    { 29, "Bryan Singer", "https://m.media-amazon.com/images/I/51G-5mwi0NL.jpg", 8.5, "The Usual Suspects", 1995 },
                    { 30, "Masaki Kobayashi", "https://m.media-amazon.com/images/I/61tQbaO5j5L._AC_SL1000_.jpg", 8.5999999999999996, "Harakiri", 1962 },
                    { 31, "Alfred Hitchcock", "https://m.media-amazon.com/images/I/51P91GZmOkL.jpg", 8.5, "Psycho", 1960 },
                    { 32, "Todd Phillips", "https://m.media-amazon.com/images/I/71wIuP89A9L._AC_SL1400_.jpg", 8.4000000000000004, "Joker", 2019 },
                    { 33, "Russo Brothers", "https://m.media-amazon.com/images/I/81ai6zx6eXL._AC_SL1500_.jpg", 8.4000000000000004, "Avengers: Infinity War", 2018 },
                    { 34, "Russo Brothers", "https://m.media-amazon.com/images/I/81ExhpBEbHL._AC_SL1500_.jpg", 8.4000000000000004, "Avengers: Endgame", 2019 },
                    { 35, "Mel Gibson", "https://m.media-amazon.com/images/I/51qCZwSUXKL.jpg", 8.3000000000000007, "Braveheart", 1995 },
                    { 36, "Martin Scorsese", "https://m.media-amazon.com/images/I/91K8M8XlC0L._AC_SL1500_.jpg", 8.1999999999999993, "The Wolf of Wall Street", 2013 },
                    { 37, "Quentin Tarantino", "https://m.media-amazon.com/images/I/81trWMMqEDL._AC_SL1500_.jpg", 8.4000000000000004, "Django Unchained", 2012 },
                    { 38, "Quentin Tarantino", "https://m.media-amazon.com/images/I/91lWvLmX48L._AC_SL1500_.jpg", 8.3000000000000007, "Inglourious Basterds", 2009 },
                    { 39, "Denis Villeneuve", "https://m.media-amazon.com/images/I/71mazqZu%2BtL._AC_SL1500_.jpg", 8.0, "Blade Runner 2049", 2017 },
                    { 40, "David Fincher", "https://m.media-amazon.com/images/I/71mUet6xxuL._AC_SL1500_.jpg", 7.7999999999999998, "The Social Network", 2010 },
                    { 41, "Alejandro G. Iñárritu", "https://m.media-amazon.com/images/I/81zMqrVwYpL._AC_SL1500_.jpg", 8.0, "The Revenant", 2015 },
                    { 42, "Ron Howard", "https://m.media-amazon.com/images/I/61DM9Rr1t5L._AC_SL1000_.jpg", 8.1999999999999993, "A Beautiful Mind", 2001 },
                    { 43, "Martin Scorsese", "https://m.media-amazon.com/images/I/81v%2B-FcVGlL._AC_SL1500_.jpg", 8.1999999999999993, "Shutter Island", 2010 },
                    { 44, "Christopher Nolan", "https://m.media-amazon.com/images/I/81sDWcoH6tL._AC_SL1500_.jpg", 8.4000000000000004, "The Dark Knight Rises", 2012 },
                    { 45, "James Mangold", "https://m.media-amazon.com/images/I/91wxPvYBn6L._AC_SL1500_.jpg", 8.0999999999999996, "Logan", 2017 },
                    { 46, "George Miller", "https://m.media-amazon.com/images/I/91oGtaqmO0L._AC_SL1500_.jpg", 8.0999999999999996, "Mad Max: Fury Road", 2015 },
                    { 47, "Peter Weir", "https://m.media-amazon.com/images/I/51K219VKHSL.jpg", 8.1999999999999993, "The Truman Show", 1998 },
                    { 48, "David Fincher", "https://m.media-amazon.com/images/I/71mUet6xxuL._AC_SL1500_.jpg", 7.7999999999999998, "The Social Network", 2010 },
                    { 49, "Alejandro G. Iñárritu", "https://m.media-amazon.com/images/I/81zMqrVwYpL._AC_SL1500_.jpg", 8.0, "The Revenant", 2015 },
                    { 50, "Ron Howard", "https://m.media-amazon.com/images/I/61DM9Rr1t5L._AC_SL1000_.jpg", 8.1999999999999993, "A Beautiful Mind", 2001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://image.tmdb.org/t/p/original/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg", 9.3000001907348633 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://image.tmdb.org/t/p/original/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", 9.1999998092651367 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://image.tmdb.org/t/p/original/dM2w364MScsjFf8pfMbaWUcWrR.jpg", 8.8999996185302734 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PosterUrl", "Rating" },
                values: new object[] { "https://image.tmdb.org/t/p/original/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg", 8.8999996185302734 });
        }
    }
}
