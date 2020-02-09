using Microsoft.EntityFrameworkCore.Migrations;

namespace KSAdmin.Migrations
{
    public partial class PostAddMainImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FileModel",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Files",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FileModel",
                table: "Posts",
                column: "FileModel",
                unique: true,
                filter: "[FileModel] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Files_FileModel",
                table: "Posts",
                column: "FileModel",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Files_FileModel",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_FileModel",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FileModel",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Files");
        }
    }
}
