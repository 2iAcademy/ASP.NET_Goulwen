using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class fixTheaterScreenRoomsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreenRoom_Theater_TheaterId",
                table: "ScreenRoom");

            migrationBuilder.DropColumn(
                name: "MovieTheaterId",
                table: "ScreenRoom");

            migrationBuilder.AlterColumn<int>(
                name: "TheaterId",
                table: "ScreenRoom",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenRoom_Theater_TheaterId",
                table: "ScreenRoom",
                column: "TheaterId",
                principalTable: "Theater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreenRoom_Theater_TheaterId",
                table: "ScreenRoom");

            migrationBuilder.AlterColumn<int>(
                name: "TheaterId",
                table: "ScreenRoom",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MovieTheaterId",
                table: "ScreenRoom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenRoom_Theater_TheaterId",
                table: "ScreenRoom",
                column: "TheaterId",
                principalTable: "Theater",
                principalColumn: "Id");
        }
    }
}
