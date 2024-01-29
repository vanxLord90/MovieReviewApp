using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReviewApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingmovietoreview4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movie_MovieId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movie_MovieId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

        }
    }
}
