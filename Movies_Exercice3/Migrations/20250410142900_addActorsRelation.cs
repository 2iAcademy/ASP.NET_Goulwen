using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class addActorsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoviePerson",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    MoviesPlayedInId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePerson", x => new { x.ActorsId, x.MoviesPlayedInId });
                    table.ForeignKey(
                        name: "FK_MoviePerson_Movie_MoviesPlayedInId",
                        column: x => x.MoviesPlayedInId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MoviePerson_Person_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviePerson_MoviesPlayedInId",
                table: "MoviePerson",
                column: "MoviesPlayedInId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviePerson");
        }
    }
}
