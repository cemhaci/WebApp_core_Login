using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp_core_Login.Migrations
{
    public partial class usertableaddprofilefile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profileImageFile",
                table: "User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "user_1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profileImageFile",
                table: "User");
        }
    }
}
