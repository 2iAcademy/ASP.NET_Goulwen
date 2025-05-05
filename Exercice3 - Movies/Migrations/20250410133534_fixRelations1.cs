using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class fixRelations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledScreening_ScreenRoom_ScreenRoomId",
                table: "ScheduledScreening");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreenRoom_MovieTheater_MovieTheaterId",
                table: "ScreenRoom");

            migrationBuilder.DropTable(
                name: "MovieTheater");

            migrationBuilder.DropIndex(
                name: "IX_ScreenRoom_MovieTheaterId",
                table: "ScreenRoom");

            migrationBuilder.DropColumn(
                name: "ScreeningRoomId",
                table: "ScheduledScreening");

            migrationBuilder.AddColumn<int>(
                name: "TheaterId",
                table: "ScreenRoom",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScreenRoomId",
                table: "ScheduledScreening",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Theater",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theater", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScreenRoom_TheaterId",
                table: "ScreenRoom",
                column: "TheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledScreening_MovieId",
                table: "ScheduledScreening",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledScreening_Movie_MovieId",
                table: "ScheduledScreening",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledScreening_ScreenRoom_ScreenRoomId",
                table: "ScheduledScreening",
                column: "ScreenRoomId",
                principalTable: "ScreenRoom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenRoom_Theater_TheaterId",
                table: "ScreenRoom",
                column: "TheaterId",
                principalTable: "Theater",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledScreening_Movie_MovieId",
                table: "ScheduledScreening");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduledScreening_ScreenRoom_ScreenRoomId",
                table: "ScheduledScreening");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreenRoom_Theater_TheaterId",
                table: "ScreenRoom");

            migrationBuilder.DropTable(
                name: "Theater");

            migrationBuilder.DropIndex(
                name: "IX_ScreenRoom_TheaterId",
                table: "ScreenRoom");

            migrationBuilder.DropIndex(
                name: "IX_ScheduledScreening_MovieId",
                table: "ScheduledScreening");

            migrationBuilder.DropColumn(
                name: "TheaterId",
                table: "ScreenRoom");

            migrationBuilder.AlterColumn<int>(
                name: "ScreenRoomId",
                table: "ScheduledScreening",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ScreeningRoomId",
                table: "ScheduledScreening",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MovieTheater",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTheater", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScreenRoom_MovieTheaterId",
                table: "ScreenRoom",
                column: "MovieTheaterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduledScreening_ScreenRoom_ScreenRoomId",
                table: "ScheduledScreening",
                column: "ScreenRoomId",
                principalTable: "ScreenRoom",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenRoom_MovieTheater_MovieTheaterId",
                table: "ScreenRoom",
                column: "MovieTheaterId",
                principalTable: "MovieTheater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
