using Microsoft.EntityFrameworkCore.Migrations;

namespace YouTubeCloneCommentsAPI.Migrations
{
    public partial class addedVideoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoId",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Comments");
        }
    }
}
