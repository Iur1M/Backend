using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Two imprisoned men form a deep bond over decades, finding hope and redemption through quiet resilience.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The patriarch of a powerful crime family hands control to his reluctant son, drawing him into a ruthless world.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Batman faces the Joker, a criminal mastermind who seeks to plunge Gotham into chaos.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Interconnected stories of crime, violence, and redemption unfold in Los Angeles.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "The final battle for Middle-earth begins as Frodo and Sam approach Mount Doom.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "A simple man experiences extraordinary moments while pursuing his lifelong love.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "An insomniac office worker creates a secret fight club that spirals into chaos.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "A skilled thief enters dreams to steal secrets, risking reality itself.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "A hacker learns reality is a simulation and joins a rebellion against its creators.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "The rise and fall of a gangster living life on the edge.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Two detectives hunt a serial killer who uses the seven deadly sins as his motive.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Explorers travel through space to save humanity from extinction.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "An FBI trainee seeks help from a brilliant cannibal to catch a serial killer.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "A group of soldiers search for a paratrooper behind enemy lines during WWII.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "The rise of organized crime in Rio de Janeiro’s most dangerous neighborhood.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "A death row guard encounters a mysterious inmate with supernatural abilities.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "A poor family infiltrates a wealthy household with unexpected consequences.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "A hitman forms an unlikely bond with a young girl seeking revenge.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "A betrayed general seeks vengeance in the Roman arena.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "A young drummer pushes himself to the limit under a ruthless instructor.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "TrailerUrl" },
                values: new object[] { "Two rival magicians engage in a deadly competition that pushes obsession to the extreme.", "https://www.youtube.com/embed/o4gHCmTQDVI" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "PosterUrl" },
                values: new object[] { "An undercover cop and a mole in the police attempt to uncover each other's identities.", "https://image.tmdb.org/t/p/w500/nT97ifVT2J1yMQmeqJ6K94mEZM1.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A Jewish pianist struggles to survive the horrors of World War II in occupied Poland.", "Roman Polanski", "Drama", "https://image.tmdb.org/t/p/w500/2hFvxCCWrTmCYwfy7yum0GKRi3Y.jpg", "The Pianist", "https://www.youtube.com/embed/BFwGqLa_oAo", 2002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A young lion prince must reclaim his rightful place as king after tragedy strikes.", "Roger Allers", "Animation", "https://image.tmdb.org/t/p/w500/2bXbqYdUdNVa8VIWXVfclP2ICtT.jpg", "The Lion King", "https://www.youtube.com/embed/4sj1MT05lAA", 1994 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Director", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A cyborg is sent back in time to protect humanity's future leader.", "James Cameron", "https://image.tmdb.org/t/p/w500/5M0j0B18abtBI5gi2RhfjjurTqb.jpg", "Terminator 2: Judgment Day", "https://www.youtube.com/embed/CRRlbK5w8AE", 1991 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A teenager travels back in time and must ensure his parents fall in love.", "Robert Zemeckis", "Sci-Fi", "https://image.tmdb.org/t/p/w500/pTpxQB1N0waaSc3OSn0e9oc8kx9.jpg", "Back to the Future", "https://www.youtube.com/embed/qvsgGtivCgs", 1985 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Director", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A former neo-Nazi tries to prevent his younger brother from following the same path.", "Tony Kaye", "https://image.tmdb.org/t/p/w500/c2gsmSQ2Cqv8zosqKOCwRS0GFBS.jpg", "American History X", "https://www.youtube.com/embed/XfQYHqsiN5g", 1998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A con man recounts the story of a legendary criminal mastermind.", "Bryan Singer", "Crime", "https://image.tmdb.org/t/p/w500/bUPmtQzrRhzqYySeiMpv7GurAfm.jpg", "The Usual Suspects", "https://www.youtube.com/embed/oiXdPolca5w", 1995 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A young girl enters a magical world ruled by spirits and strange creatures.", "Hayao Miyazaki", "Animation", "https://image.tmdb.org/t/p/w500/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg", 8.5999999999999996, "Spirited Away", "https://www.youtube.com/embed/ByXuk9QqQkk", 2001 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "An unlikely friendship forms between a quadriplegic man and his caretaker.", "Olivier Nakache", "Comedy", "https://image.tmdb.org/t/p/w500/4mFsNQwbD0F237Tx7gAPotd0nbJ.jpg", 8.5, "The Intouchables", "https://www.youtube.com/embed/34WIbmXkewU", 2011 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A factory worker struggles to survive in an increasingly industrialized society.", "Charlie Chaplin", "Comedy", "https://image.tmdb.org/t/p/w500/7u0aYf8E3a2RZkHcZ9zH8fF2A3I.jpg", "Modern Times", "https://www.youtube.com/embed/GLeDdzGUTq0", 1936 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A woman checks into a secluded motel where dark secrets lurk.", "Alfred Hitchcock", "Horror", "https://image.tmdb.org/t/p/w500/81d8oyEFgj7FlxJqSDXWr8JH8kV.jpg", 8.5, "Psycho", "https://www.youtube.com/embed/Wz719b9QUqY", 1960 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A mysterious stranger aids a widow in protecting her land from ruthless criminals.", "Sergio Leone", "Western", "https://image.tmdb.org/t/p/w500/9uGHEgsiUXjCNq8wdq4r49YL8A1.jpg", 8.5, "Once Upon a Time in the West", "https://www.youtube.com/embed/ojrVbm5p-UE", 1968 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A nightclub owner must choose between love and sacrifice during World War II.", "Michael Curtiz", "Romance", "https://image.tmdb.org/t/p/w500/5K7cOHoay2mZusSLezBOY0Qxh8a.jpg", 8.5, "Casablanca", "https://www.youtube.com/embed/BkL9l7qovsE", 1942 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A tramp falls in love with a blind flower girl and tries to change her life.", "Charlie Chaplin", "Comedy", "https://image.tmdb.org/t/p/w500/uZBW2Gf8r8y2UP2Y4Wf0xZPjQzN.jpg", 8.5, "City Lights", "https://www.youtube.com/embed/7vl7F8S4cpQ", 1931 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A family becomes trapped in a haunted hotel during winter isolation.", "Stanley Kubrick", "Horror", "https://image.tmdb.org/t/p/w500/9fgh3Ns1iRzlQNYuJyK0ARQZU7w.jpg", 8.4000000000000004, "The Shining", "https://www.youtube.com/embed/5Cb3ik6zP2I", 1980 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Earth's mightiest heroes unite to stop a powerful cosmic threat.", "Anthony Russo", "Action", "https://image.tmdb.org/t/p/w500/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg", "Avengers: Infinity War", "https://www.youtube.com/embed/6ZfuNTqbHE8", 2018 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "The Avengers make one final stand to restore balance to the universe.", "Anthony Russo", "Action", "https://image.tmdb.org/t/p/w500/ulzhLuWrPK07P1YkdWQLZnQh1JL.jpg", 8.4000000000000004, "Avengers: Endgame", "https://www.youtube.com/embed/TcMBFSGVi1c", 2019 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A failed comedian descends into madness, becoming Gotham's infamous villain.", "Todd Phillips", "Drama", "https://image.tmdb.org/t/p/w500/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg", 8.4000000000000004, "Joker", "https://www.youtube.com/embed/zAGVQLHvwOY", 2019 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Two strangers mysteriously swap bodies across time and space.", "Makoto Shinkai", "Animation", "https://image.tmdb.org/t/p/w500/q719jXXEzOoYaps6babgKnONONX.jpg", 8.4000000000000004, "Your Name", "https://www.youtube.com/embed/xU47nhruN-Q", 2016 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A boy journeys into the Land of the Dead to uncover his family's past.", "Lee Unkrich", "Animation", "https://image.tmdb.org/t/p/w500/gGEsBPAijhVUFoiNpgZXqRVWJt2.jpg", 8.4000000000000004, "Coco", "https://www.youtube.com/embed/Ga6RYejo6Hk", 2017 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A freed slave sets out to rescue his wife with the help of a bounty hunter.", "Quentin Tarantino", "Western", "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg", 8.4000000000000004, "Django Unchained", "https://www.youtube.com/embed/eUdM9vrCbow", 2012 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A stockbroker rises to extreme wealth through corruption and excess.", "Biography", "https://image.tmdb.org/t/p/w500/pWHf4khOloNVfCxscsXFj3jj6gP.jpg", 8.4000000000000004, "The Wolf of Wall Street", "https://www.youtube.com/embed/iszwuX1AK6A", 2013 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A man seeks revenge after being imprisoned for years without explanation.", "Park Chan-wook", "Thriller", "https://image.tmdb.org/t/p/w500/pWDtjs568ZfOTMbURQBYuT4Qxka.jpg", "Oldboy", "https://www.youtube.com/embed/2HkjrJ6IK5E", 2003 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A young warrior becomes involved in a conflict between nature and industry.", "Hayao Miyazaki", "Animation", "https://image.tmdb.org/t/p/w500/jHWmNr7m544fJ8eItsfNk8fs2Ed.jpg", 8.4000000000000004, "Princess Mononoke", "https://www.youtube.com/embed/4OiMOHRDs14", 1997 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A man slowly discovers his entire life is a televised reality show.", "Peter Weir", "Drama", "https://image.tmdb.org/t/p/w500/vuza0WqY239yBXOadKlGwJsZJFE.jpg", 8.1999999999999993, "The Truman Show", "https://www.youtube.com/embed/dlnmQbPGuls", 1998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A new blade runner uncovers a secret that could destabilize society.", "Denis Villeneuve", "Sci-Fi", "https://image.tmdb.org/t/p/w500/aMpyrCizvSdc0UIMblJ1srVgAEF.jpg", 8.0, "Blade Runner 2049", "https://www.youtube.com/embed/gCcx85zbxz4", 2017 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Director", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A hotel concierge and his protégé become entangled in a bizarre adventure.", "Wes Anderson", "https://image.tmdb.org/t/p/w500/eWdyYQreja6JGCzqHWXpWHDrrPo.jpg", "The Grand Budapest Hotel", "https://www.youtube.com/embed/1Fg5iWmQjwk", 2014 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "A violent youth undergoes controversial psychological conditioning.", "Stanley Kubrick", "Crime", "https://image.tmdb.org/t/p/w500/4sHeTAp65WrSSuc05nRBKddhBxO.jpg", 8.3000000000000007, "A Clockwork Orange", "https://www.youtube.com/embed/T54uZPI4Z8A", 1971 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Director", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Four lives spiral into addiction and despair in haunting fashion.", "Darren Aronofsky", "https://image.tmdb.org/t/p/w500/nOd6vjEmzCT0k4VYqsA2hwyi87C.jpg", 8.3000000000000007, "Requiem for a Dream", "https://www.youtube.com/embed/jzk-lmU4KZ4", 2000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Leonardo DiCaprio" },
                    { 2, "Brad Pitt" },
                    { 3, "Morgan Freeman" },
                    { 4, "Christian Bale" },
                    { 5, "Robert De Niro" },
                    { 6, "Al Pacino" },
                    { 7, "Tom Hanks" },
                    { 8, "Johnny Depp" },
                    { 9, "Keanu Reeves" },
                    { 10, "Matthew McConaughey" },
                    { 11, "Samuel L. Jackson" },
                    { 12, "Ryan Gosling" }
                });

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
                column: "PosterUrl",
                value: "https://image.tmdb.org/t/p/w500/nT97ifVT2J1yMQmeq20Qblg61T.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Roger Allers", "Animation", "https://image.tmdb.org/t/p/w500/sKCr78MXSLixwmZ8DyJLrpMsd15.jpg", "The Lion King", "https://www.youtube.com/embed/7TavVZMewpY", 1994 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "James Cameron", "Action", "https://image.tmdb.org/t/p/w500/5M0j0B18abtBI5gi2RhfjjurTqb.jpg", "Terminator 2: Judgment Day", "https://www.youtube.com/embed/CRRlbK5w8AE", 1991 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Director", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Robert Zemeckis", "https://image.tmdb.org/t/p/w500/pTpxQB1N0waaSc3OSn0e9oc8kx9.jpg", "Back to the Future", "https://www.youtube.com/embed/qvsgGtivCgs", 1985 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Ridley Scott", "Horror", "https://image.tmdb.org/t/p/w500/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg", "Alien", "https://www.youtube.com/embed/LjLamj-b0I8", 1979 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Director", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Roman Polanski", "https://image.tmdb.org/t/p/w500/2hFvxCCWrTmCYwfy7yum0GKRi3Y.jpg", "The Pianist", "https://www.youtube.com/embed/u_jE7-6Uv7E", 2002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Tony Kaye", "Drama", "https://image.tmdb.org/t/p/w500/c2gsmSQ2Cqv8zosqKOCwRS0GFBS.jpg", "American History X", "https://www.youtube.com/embed/XfQYHqsiN5g", 1998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Bryan Singer", "Crime", "https://image.tmdb.org/t/p/w500/bUPmtQzrRhzqYySeiMpv7GurAfm.jpg", 8.5, "The Usual Suspects", "https://www.youtube.com/embed/oiXdPolca5w", 1995 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Masaki Kobayashi", "Drama", "https://image.tmdb.org/t/p/w500/5konZnIbcAxZjP616Cz5o9bKEfW.jpg", 8.5999999999999996, "Harakiri", "https://www.youtube.com/embed/W5MTdkj5c-Q", 1962 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Alfred Hitchcock", "Horror", "https://image.tmdb.org/t/p/w500/81d8oyEFgj7FlxJqSDXWr8JH8kV.jpg", "Psycho", "https://www.youtube.com/embed/NG3-GlvKPcg", 1960 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Todd Phillips", "Drama", "https://image.tmdb.org/t/p/w500/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg", 8.4000000000000004, "Joker", "https://www.youtube.com/embed/zAGVQLHvwOY", 2019 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Russo Brothers", "Action", "https://image.tmdb.org/t/p/w500/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg", 8.4000000000000004, "Avengers: Infinity War", "https://www.youtube.com/embed/6ZfuNTqbHE8", 2018 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Russo Brothers", "Action", "https://image.tmdb.org/t/p/w500/or06FN3Dka5tukK1e9sl16pB3iy.jpg", 8.4000000000000004, "Avengers: Endgame", "https://www.youtube.com/embed/TcMBFSGVi1c", 2019 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Mel Gibson", "War", "https://image.tmdb.org/t/p/w500/or1gBugydmjToAEq7OZY0owwFk.jpg", 8.3000000000000007, "Braveheart", "https://www.youtube.com/embed/1NJO0jxBtMo", 1995 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Martin Scorsese", "Drama", "https://image.tmdb.org/t/p/w500/pWHf4khOloNVfCxscsXFj3jj6gP.jpg", 8.1999999999999993, "The Wolf of Wall Street", "https://www.youtube.com/embed/iszwuX1AK6A", 2013 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Quentin Tarantino", "Western", "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg", "Django Unchained", "https://www.youtube.com/embed/0fUCuvNlOCg", 2012 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Quentin Tarantino", "War", "https://image.tmdb.org/t/p/w500/7sfbEnaARXDDhKm0CZ7D7uc2sbo.jpg", 8.3000000000000007, "Inglourious Basterds", "https://www.youtube.com/embed/KnrRy6kSFF0", 2009 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Denis Villeneuve", "Sci-Fi", "https://image.tmdb.org/t/p/w500/gajva2L0rPYkEWjzgFlBXCAVBE5.jpg", 8.0, "Blade Runner 2049", "https://www.youtube.com/embed/gCcx85zbxz4", 2017 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "David Fincher", "Drama", "https://image.tmdb.org/t/p/w500/n0ybibhJtQ5icDqTp8eRytcIHJx.jpg", 7.7999999999999998, "The Social Network", "https://www.youtube.com/embed/lB95KLmpLR4", 2010 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Alejandro G. Iñárritu", "Adventure", "https://image.tmdb.org/t/p/w500/oXUWEc5i3wYyFnL1Ycu8ppxxPvs.jpg", 8.0, "The Revenant", "https://www.youtube.com/embed/LoebZZ8K5N0", 2015 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Ron Howard", "Drama", "https://image.tmdb.org/t/p/w500/zwzWCmH72OSC9NA0ipoqw5Zjya8.jpg", 8.1999999999999993, "A Beautiful Mind", "https://www.youtube.com/embed/aS_d0Ayjw4o", 2001 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Thriller", "https://image.tmdb.org/t/p/w500/kve20tXwUZpu4GUX8l6X7Z4jmL6.jpg", 8.1999999999999993, "Shutter Island", "https://www.youtube.com/embed/5iaYLCiq5RM", 2010 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Director", "Genre", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Christopher Nolan", "Action", "https://image.tmdb.org/t/p/w500/hr0L2aueqlP2BYUblTTjmtn0hw4.jpg", "The Dark Knight Rises", "https://www.youtube.com/embed/GokKUqLcvD8", 2012 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "James Mangold", "Action", "https://image.tmdb.org/t/p/w500/fnbjcRDYn6YviCcePDnGdyAkYsB.jpg", 8.0999999999999996, "Logan", "https://www.youtube.com/embed/Div0iP65aZo", 2017 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "George Miller", "Action", "https://image.tmdb.org/t/p/w500/8tZYtuWezp8JbcsvHYO0O46tFbo.jpg", 8.0999999999999996, "Mad Max: Fury Road", "https://www.youtube.com/embed/hEJnMQG9ev8", 2015 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Peter Weir", "Drama", "https://image.tmdb.org/t/p/w500/vt1u0lHk3O2Yp6u7p9p6ZxQ5ZbM.jpg", 8.1999999999999993, "The Truman Show", "https://www.youtube.com/embed/dlnmQbPGuls", 1998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Director", "PosterUrl", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Coen Brothers", "https://image.tmdb.org/t/p/w500/5DxkT6yWEYyFjPZtxe2F0KxL5T4.jpg", "The Big Lebowski", "https://www.youtube.com/embed/cd-go0oBF4Y", 1998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Director", "Genre", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Coen Brothers", "Thriller", "https://image.tmdb.org/t/p/w500/6o0fQX0uTzE3C8f6TRf0wK6n6Qx.jpg", 8.0999999999999996, "No Country for Old Men", "https://www.youtube.com/embed/38A__WT3-o0", 2007 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Director", "PosterUrl", "Rating", "Title", "TrailerUrl", "Year" },
                values: new object[] { "Paul Thomas Anderson", "https://image.tmdb.org/t/p/w500/fa0RDkAlCec0STeMNAhPaF89q6C.jpg", 8.1999999999999993, "There Will Be Blood", "https://www.youtube.com/embed/FeSLPELpMeM", 2007 });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 7, 5 },
                    { 9, 6 },
                    { 11, 7 },
                    { 10, 8 },
                    { 1, 9 },
                    { 12, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActors",
                column: "ActorId");
        }
    }
}
