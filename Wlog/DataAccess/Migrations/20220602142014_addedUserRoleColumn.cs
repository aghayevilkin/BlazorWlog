using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addedUserRoleColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserRoleRoleId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserRoleUserId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserRoleUserId_UserRoleRoleId",
                table: "AspNetUsers",
                columns: new[] { "UserRoleUserId", "UserRoleRoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUserRoles_UserRoleUserId_UserRoleRoleId",
                table: "AspNetUsers",
                columns: new[] { "UserRoleUserId", "UserRoleRoleId" },
                principalTable: "AspNetUserRoles",
                principalColumns: new[] { "UserId", "RoleId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUserRoles_UserRoleUserId_UserRoleRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserRoleUserId_UserRoleRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserRoleRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserRoleUserId",
                table: "AspNetUsers");
        }
    }
}
