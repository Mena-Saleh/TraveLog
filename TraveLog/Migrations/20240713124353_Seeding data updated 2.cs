using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraveLog.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdataupdated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "Pyramids.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "Karnak Temple.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "Hatshepsut Temple.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "Vasa Museum.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "Kalmar Castle.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "Amber Palace.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "Taj Mahal.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/Countries/Egypt/Pyramids.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/Countries/Egypt/Karnak Temple.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/Countries/Egypt/Hatshepsut Temple.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/images/Countries/Sweden/Vasa Museum.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "~/images/Countries/Sweden/Kalmar Castle.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "~/images/Countries/India/Amber Palace.jpg");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "~/images/Countries/India/Taj Mahal.jpg");
        }
    }
}
