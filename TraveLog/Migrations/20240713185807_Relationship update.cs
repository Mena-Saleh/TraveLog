using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraveLog.Migrations
{
    /// <inheritdoc />
    public partial class Relationshipupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_AspNetUsers_ApplicationUserId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_ApplicationUserId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Countries");

            migrationBuilder.CreateTable(
                name: "ApplicationUserCountry",
                columns: table => new
                {
                    CountryVisitorsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VisitedCountriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserCountry", x => new { x.CountryVisitorsId, x.VisitedCountriesId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserCountry_AspNetUsers_CountryVisitorsId",
                        column: x => x.CountryVisitorsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserCountry_Countries_VisitedCountriesId",
                        column: x => x.VisitedCountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserCountry_VisitedCountriesId",
                table: "ApplicationUserCountry",
                column: "VisitedCountriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserCountry");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ApplicationUserId",
                table: "Countries",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_AspNetUsers_ApplicationUserId",
                table: "Countries",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
