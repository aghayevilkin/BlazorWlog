using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class newsDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "News",
                type: "ntext",
                nullable: false,
                defaultValue: "");
        }
    }
}
