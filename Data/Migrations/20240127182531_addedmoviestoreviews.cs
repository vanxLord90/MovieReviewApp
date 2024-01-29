using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReviewApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedmoviestoreviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movie_TitleId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "TitleId",
                table: "Review",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_TitleId",
                table: "Review",
                newName: "IX_Review_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movie_MovieId",
                table: "Review",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movie_MovieId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Review",
                newName: "TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_MovieId",
                table: "Review",
                newName: "IX_Review_TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movie_TitleId",
                table: "Review",
                column: "TitleId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
