using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MatData.Migrations
{
    public partial class AddIndicatorResponse2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndicatorResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IndicatorId = table.Column<int>(type: "integer", nullable: true),
                    ProvinceId = table.Column<int>(type: "integer", nullable: true),
                    MunicipeId = table.Column<int>(type: "integer", nullable: true),
                    UrbanDistrictCommuneId = table.Column<int>(type: "integer", nullable: true),
                    NeighborhoodVillageId = table.Column<int>(type: "integer", nullable: true),
                    Data = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicatorResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndicatorResponses_Indicators_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "Indicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndicatorResponses_Municipes_MunicipeId",
                        column: x => x.MunicipeId,
                        principalTable: "Municipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndicatorResponses_NeighborhoodVillages_NeighborhoodVillage~",
                        column: x => x.NeighborhoodVillageId,
                        principalTable: "NeighborhoodVillages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndicatorResponses_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndicatorResponses_UrbanDistrictCommunes_UrbanDistrictCommu~",
                        column: x => x.UrbanDistrictCommuneId,
                        principalTable: "UrbanDistrictCommunes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorResponses_IndicatorId",
                table: "IndicatorResponses",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorResponses_MunicipeId",
                table: "IndicatorResponses",
                column: "MunicipeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorResponses_NeighborhoodVillageId",
                table: "IndicatorResponses",
                column: "NeighborhoodVillageId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorResponses_ProvinceId",
                table: "IndicatorResponses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorResponses_UrbanDistrictCommuneId",
                table: "IndicatorResponses",
                column: "UrbanDistrictCommuneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndicatorResponses");
        }
    }
}
