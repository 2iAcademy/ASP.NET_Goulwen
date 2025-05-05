using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class testRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Theater");

            migrationBuilder.CreateTable(
                name: "MovieTheater",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTheater", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScreenRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTheaterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScreenRoom_MovieTheater_MovieTheaterId",
                        column: x => x.MovieTheaterId,
                        principalTable: "MovieTheater",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScreenRoom_MovieTheaterId",
                table: "ScreenRoom",
                column: "MovieTheaterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScreenRoom");

            migrationBuilder.DropTable(
                name: "MovieTheater");

            migrationBuilder.CreateTable(
                name: "Theater",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theater", x => x.Id);
                });
        }
    }
}
