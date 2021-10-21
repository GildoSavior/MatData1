using Microsoft.EntityFrameworkCore.Migrations;

namespace MatData.Migrations
{
    public partial class AddCodeNameToTheme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodName",
                table: "Themes",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodName",
                table: "Themes");
        }
    }
}
