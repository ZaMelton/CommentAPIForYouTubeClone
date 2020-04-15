using Microsoft.EntityFrameworkCore.Migrations;

namespace YouTubeCloneCommentsAPI.Migrations
{
    public partial class addedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Comments");
        }
    }
}
