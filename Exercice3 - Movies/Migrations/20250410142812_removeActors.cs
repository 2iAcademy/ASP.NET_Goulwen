using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class removeActors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Movie_MovieId",
                table: "Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Person_DirectorId",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Movie_MovieId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_MovieId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Genre_MovieId",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Genre");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Person",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenreId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_FullName",
                table: "Person",
                column: "FullName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Person_DirectorId",
                table: "Movie",
                column: "DirectorId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Person_DirectorId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropIndex(
                name: "IX_Person_FullName",
                table: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Genre",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_MovieId",
                table: "Person",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_MovieId",
                table: "Genre",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Movie_MovieId",
                table: "Genre",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Person_DirectorId",
                table: "Movie",
                column: "DirectorId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Movie_MovieId",
                table: "Person",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id");
        }
    }
}
