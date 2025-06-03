using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class fixGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genre_GenreId",
                table: "GenreMovie");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GenreMovie",
                newName: "GenresId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genre_GenresId",
                table: "GenreMovie",
                column: "GenresId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genre_GenresId",
                table: "GenreMovie");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "GenreMovie",
                newName: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genre_GenreId",
                table: "GenreMovie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
