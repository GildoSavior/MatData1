using Microsoft.EntityFrameworkCore.Migrations;

namespace MatData.Migrations
{
    public partial class RemoveCodNameToTheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodName",
                table: "Themes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodName",
                table: "Themes",
                type: "text",
                nullable: true);
        }
    }
}
