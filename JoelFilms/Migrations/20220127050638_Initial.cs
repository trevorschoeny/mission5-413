using Microsoft.EntityFrameworkCore.Migrations;

namespace JoelFilms.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Joss Whedon", false, null, null, "PG-13", "The Avengers", (short)2012 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Science Fiction", "Christopher Nolan", false, null, null, "PG-13", "Interstellar", (short)2014 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Drama", "Destin Daniel Cretton", false, null, null, "PG-13", "Just Mercy", (short)2019 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
