using Microsoft.EntityFrameworkCore.Migrations;

namespace MatData.Migrations
{
    public partial class AddUserFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MunicipeId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordConfirm",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_MunicipeId",
                table: "Users",
                column: "MunicipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProvinceId",
                table: "Users",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Municipes_MunicipeId",
                table: "Users",
                column: "MunicipeId",
                principalTable: "Municipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Provinces_ProvinceId",
                table: "Users",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Municipes_MunicipeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Provinces_ProvinceId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_MunicipeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProvinceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MunicipeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordConfirm",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");
        }
    }
}
