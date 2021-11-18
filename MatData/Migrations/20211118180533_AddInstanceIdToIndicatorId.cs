using Microsoft.EntityFrameworkCore.Migrations;

namespace MatData.Migrations
{
    public partial class AddInstanceIdToIndicatorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstanceId",
                table: "IndicatorResponses",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstanceId",
                table: "IndicatorResponses");
        }
    }
}
