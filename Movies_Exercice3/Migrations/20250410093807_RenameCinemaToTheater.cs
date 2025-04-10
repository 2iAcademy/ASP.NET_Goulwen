using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class RenameCinemaToTheater : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cinema");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Theater");

            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.Id);
                });
        }
    }
}
