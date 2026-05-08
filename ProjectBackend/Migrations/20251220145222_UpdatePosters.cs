using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePosters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/fIE3lAGcZDV1G6XM5KmuWnNsPp1.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/saHP97rTPS5eLmrLQEcANmKrsFl.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/bptfVGEQuv6vDTIMVCHjJ9Dz8PX.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/f89U3ADr1oiB1s9GkdPOEpXUk5H.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/aKuFiU82s5ISJpGZp7YkIr3kCUd.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PosterUrl", "Title" },
                values: new object[] { "https://image.tmdb.org/t/p/w500/6yoghtyTpznpBik8EngEmJskVUO.jpg", "Se7en" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/uS9m8OBk1A8eM9I042bx8XXpqAq.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/uqx37cS8cpHg8U35f9U5IBlrCV3.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/k7eYdWvhYQyRQoU2TB2A2Xu2TfD.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/o0lO84GI7qrG6XFvtsPOSV7CTNa.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/7IiTTgloJzvGI1TAYymCfbfl3vT.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PosterUrl", "Title" },
                values: new object[] { "https://image.tmdb.org/t/p/w500/yI6X2cCM5YPJtxMhUd3dPGqDAhw.jpg", "Léon: The Professional" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/6uSPcdGJAkF6P5kP1K9z5i2nV8p.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/5MXyQfz8xUP3dIFPTubhTsbFY6N.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/nT97ifVT2J1yMQmeq20Qblg61T.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/sKCr78MXSLixwmZ8DyJLrpMsd15.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/5M0j0B18abtBI5gi2RhfjjurTqb.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/pTpxQB1N0waaSc3OSn0e9oc8kx9.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/2hFvxCCWrTmCYwfy7yum0GKRi3Y.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/c2gsmSQ2Cqv8zosqKOCwRS0GFBS.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/bUPmtQzrRhzqYySeiMpv7GurAfm.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/5konZnIbcAxZjP616Cz5o9bKEfW.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/81d8oyEFgj7FlxJqSDXWr8JH8kV.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/or06FN3Dka5tukK1e9sl16pB3iy.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/or1gBugydmjToAEq7OZY0owwFk.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/pWHf4khOloNVfCxscsXFj3jj6gP.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/7sfbEnaARXDDhKm0CZ7D7uc2sbo.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/gajva2L0rPYkEWjzgFlBXCAVBE5.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/n0ybibhJtQ5icDqTp8eRytcIHJx.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/oXUWEc5i3wYyFnL1Ycu8ppxxPvs.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/zwzWCmH72OSC9NA0ipoqw5Zjya8.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/kve20tXwUZpu4GUX8l6X7Z4jmL6.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/hr0L2aueqlP2BYUblTTjmtn0hw4.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/fnbjcRDYn6YviCcePDnGdyAkYsB.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/8tZYtuWezp8JbcsvHYO0O46tFbo.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/vt1u0lHk3O2Yp6u7p9p6ZxQ5ZbM.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Director", "PosterUrl", "Rating", "Title", "Year" },
                values: new object[] { "Coen Brothers", "https://image.tmdb.org/t/p/w500/5DxkT6yWEYyFjPZtxe2F0KxL5T4.jpg", 8.0999999999999996, "The Big Lebowski", 1998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Director", "PosterUrl", "Rating", "Title", "Year" },
                values: new object[] { "Coen Brothers", "https://image.tmdb.org/t/p/w500/6o0fQX0uTzE3C8f6TRf0wK6n6Qx.jpg", 8.0999999999999996, "No Country for Old Men", 2007 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Director", "PosterUrl", "Title", "Year" },
                values: new object[] { "Paul Thomas Anderson", "https://image.tmdb.org/t/p/w500/fa0RDkAlCec0STeMNAhPaF89q6C.jpg", "There Will Be Blood", 2007 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51NiGlapXlL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/41+eK8zBwQL.jpg");

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
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SL1024_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/61+Kz2Rk6JL._AC_SL1000_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/71vV1SWnSUL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51vbF7DheLL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51EG732BV3L.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51edC+FODKL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PosterUrl", "Title" },
                values: new object[] { "https://m.media-amazon.com/images/I/71rNJQ2g-QL._AC_SL1500_.jpg", "Seven" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51WcRoWSQlL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51P1n0Pp-rL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51hYwc3%2BcbL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51k0qa6zH-L.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/71cIkzdg86L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PosterUrl", "Title" },
                values: new object[] { "https://m.media-amazon.com/images/I/51Vp5cv16fL.jpg", "Leon: The Professional" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51A7Q6Qac7L.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/81VStYnDGrL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51Y-8jb8eVL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51U1vgbuEoL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51XX-7bb2YL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51FzPxPV6mL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51T9V5W3uqL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/71VmOAX-HcL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51DGiokwbrL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51w0nggYJTL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51G-5mwi0NL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/61tQbaO5j5L._AC_SL1000_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51P91GZmOkL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/71wIuP89A9L._AC_SL1400_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/81ai6zx6eXL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/81ExhpBEbHL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51qCZwSUXKL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/91K8M8XlC0L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/81trWMMqEDL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/91lWvLmX48L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/71mazqZu%2BtL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/71mUet6xxuL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/81zMqrVwYpL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/61DM9Rr1t5L._AC_SL1000_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/81v%2B-FcVGlL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/81sDWcoH6tL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/91wxPvYBn6L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/91oGtaqmO0L._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                column: "PosterUrl",
                value: "https://m.media-amazon.com/images/I/51K219VKHSL.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Director", "PosterUrl", "Rating", "Title", "Year" },
                values: new object[] { "David Fincher", "https://m.media-amazon.com/images/I/71mUet6xxuL._AC_SL1500_.jpg", 7.7999999999999998, "The Social Network", 2010 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Director", "PosterUrl", "Rating", "Title", "Year" },
                values: new object[] { "Alejandro G. Iñárritu", "https://m.media-amazon.com/images/I/81zMqrVwYpL._AC_SL1500_.jpg", 8.0, "The Revenant", 2015 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Director", "PosterUrl", "Title", "Year" },
                values: new object[] { "Ron Howard", "https://m.media-amazon.com/images/I/61DM9Rr1t5L._AC_SL1000_.jpg", "A Beautiful Mind", 2001 });
        }
    }
}
