using Microsoft.EntityFrameworkCore.Migrations;

namespace KSAdmin.Migrations
{
    public partial class PostAddMainImage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Posts_FileModel",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "MainImageId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FileModel",
                table: "Posts",
                column: "FileModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Posts_FileModel",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "MainImageId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FileModel",
                table: "Posts",
                column: "FileModel",
                unique: true,
                filter: "[FileModel] IS NOT NULL");
        }
    }
}
