using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exercice3.Migrations
{
    /// <inheritdoc />
    public partial class ModelCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreenRoom_MovieTheater_MovieTheaterId",
                table: "ScreenRoom");

            migrationBuilder.AlterColumn<int>(
                name: "MovieTheaterId",
                table: "ScreenRoom",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "ScreenRoom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ScreenRoom",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MovieTheater",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ScheduledScreening",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ScreeningRoomId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationsCount = table.Column<int>(type: "int", nullable: false),
                    ScreenRoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledScreening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledScreening_ScreenRoom_ScreenRoomId",
                        column: x => x.ScreenRoomId,
                        principalTable: "ScreenRoom",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledScreening_ScreenRoomId",
                table: "ScheduledScreening",
                column: "ScreenRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenRoom_MovieTheater_MovieTheaterId",
                table: "ScreenRoom",
                column: "MovieTheaterId",
                principalTable: "MovieTheater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScreenRoom_MovieTheater_MovieTheaterId",
                table: "ScreenRoom");

            migrationBuilder.DropTable(
                name: "ScheduledScreening");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "ScreenRoom");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ScreenRoom");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MovieTheater");

            migrationBuilder.AlterColumn<int>(
                name: "MovieTheaterId",
                table: "ScreenRoom",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ScreenRoom_MovieTheater_MovieTheaterId",
                table: "ScreenRoom",
                column: "MovieTheaterId",
                principalTable: "MovieTheater",
                principalColumn: "Id");
        }
    }
}
