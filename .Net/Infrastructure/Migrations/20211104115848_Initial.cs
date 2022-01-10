using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actor_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Jack Nicholson" },
                    { 25, "Samy Naceri" },
                    { 26, "Frédéric Diefenthal" },
                    { 27, "Robert De Niro" },
                    { 28, "Michelle Pfeiffer" },
                    { 30, "Jean Reno" },
                    { 31, "Gary Oldman" },
                    { 32, "Natalie Portman" },
                    { 33, "Hugh Jackman" },
                    { 34, "Scarlett Johansson" },
                    { 35, "Mark Ruffalo" },
                    { 36, "Bill Skarsgård" },
                    { 37, "Sophia Lillis" },
                    { 38, "John Travolta" },
                    { 39, "Uma Thurman" },
                    { 40, "Bruce Willis" },
                    { 41, "Keanu Reeves" },
                    { 42, "Laurence Fishburne" },
                    { 43, "Carrie-Anne Moss" },
                    { 44, "Hugo Weaving" },
                    { 24, "Michael Madsen" },
                    { 23, "Tim Roth" },
                    { 29, "Tommy Lee Jones" },
                    { 21, "Samuel L. Jackson" },
                    { 2, "Shelley Duvall" },
                    { 3, "Keir Dullea" },
                    { 4, "Gary Lockwood" },
                    { 22, "Kurt Russell" },
                    { 6, "Heath Ledger" },
                    { 7, "Leonardo DiCaprio" },
                    { 8, "Joseph Gordon-Levitt" },
                    { 9, "Tom Hardy" },
                    { 10, "Michael Caine" },
                    { 11, "Cillian Murphy" },
                    { 5, "Christian Bale" },
                    { 13, "Jason Flemyng" },
                    { 14, "Jason Statham" },
                    { 15, "Vinnie Jones" },
                    { 16, "Robert Downey Jr." },
                    { 17, "Jude Law" },
                    { 18, "Mark Strong" },
                    { 19, "Jamie Foxx" }
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 20, "Christoph Waltz" },
                    { 12, "Marion Cotillard" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "The Wachowskis" },
                    { 7, "Andy Muschietti" },
                    { 6, "Martin Scorsese" },
                    { 5, "Luc Besson" },
                    { 3, "Guy Ritchie" },
                    { 2, "Christopher Nolan" },
                    { 1, "Stanley Kubrick" },
                    { 4, "Quentin Tarantino" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Comedy" },
                    { 1, "Horror" },
                    { 2, "Thriller" },
                    { 3, "Fantasy" },
                    { 4, "Detective" },
                    { 6, "Western" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "DirectorId", "GenreId", "Image", "Name", "Rating", "Slug", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, "https://upload.wikimedia.org/wikipedia/en/1/1d/The_Shining_%281980%29_U.K._release_poster_-_The_tide_of_terror_that_swept_America_IS_HERE.jpg", "Shining", 10.9, "shinig--1980", 1980 },
                    { 13, 6, 1, "https://upload.wikimedia.org/wikipedia/en/7/76/Shutterislandposter.jpg", "Shutter Island", 10.4, "shutter-island--2010", 2010 },
                    { 14, 7, 1, "https://upload.wikimedia.org/wikipedia/en/5/5a/It_%282017%29_poster.jpg", "It", 10.0, "it--2017", 2017 },
                    { 3, 2, 2, "https://upload.wikimedia.org/wikipedia/en/8/8a/Dark_Knight.jpg", "The Dark Knight", 9.8000000000000007, "the-dark-knight--2008", 2008 },
                    { 5, 3, 2, "https://images.wolfgangsvault.com/m/xlarge/ZZZ061560-PO/lock-stock-and-two-smoking-barrels-poster-mar-5-1999.webp", "Lock, Stock and Two Smoking Barrels", 11.0, "lock-stock-and-two-smoking-barrels--1998", 1998 },
                    { 11, 5, 2, "https://upload.wikimedia.org/wikipedia/uk/e/e1/L%C3%A9on_poster.JPG", "Léon: The Professional", 10.9, "léon-the-proffesional--1994", 1994 },
                    { 15, 4, 2, "https://upload.wikimedia.org/wikipedia/en/3/3b/Pulp_Fiction_%281994%29_poster.jpg", "Pulp Fiction", 11.800000000000001, "pulp-fiction--1994", 1994 },
                    { 2, 1, 3, "https://upload.wikimedia.org/wikipedia/en/1/11/2001_A_Space_Odyssey_%281968%29.png", "2001: A Space Odyssey", 10.199999999999999, "2001-a-space-odyssey--1968", 1968 },
                    { 4, 2, 3, "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg", "Inception", 11.1, "inception--2010", 2010 },
                    { 16, 8, 3, "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/The_Matrix_Poster.jpg/220px-The_Matrix_Poster.jpg", "The Matrix", 11.300000000000001, "the-matrix--1999", 1999 },
                    { 6, 3, 4, "https://m.media-amazon.com/images/M/MV5BMTg0NjEwNjUxM15BMl5BanBnXkFtZTcwMzk0MjQ5Mg@@._V1_.jpg", "Sherlock Holmes", 9.6999999999999993, "sherlock-holmes--2009", 2009 },
                    { 12, 2, 4, "https://i.pinimg.com/originals/02/88/8a/02888af9053561a41e4276e33588403b.jpg", "The Prestige", 10.199999999999999, "prestige--2006", 2006 },
                    { 9, 5, 5, "https://upload.wikimedia.org/wikipedia/en/7/7e/TaxiPoster.jpg", "Taxi", 10.5, "taxi--1998", 1998 },
                    { 10, 5, 5, "https://upload.wikimedia.org/wikipedia/en/7/75/The_Family_2013%2C_Poster.jpg", "Malavita", 9.6999999999999993, "malavita--2013", 2013 },
                    { 7, 4, 6, "https://upload.wikimedia.org/wikipedia/en/8/8b/Django_Unchained_Poster.jpg", "Django Unchained", 11.0, "django-unchained--2012", 2012 },
                    { 8, 4, 6, "https://upload.wikimedia.org/wikipedia/en/d/d4/The_Hateful_Eight.jpg", "The Hatefull Eight", 10.0, "the-hatefull-eight--2015", 2015 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MoviesId",
                table: "ActorMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorId",
                table: "Movie",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
