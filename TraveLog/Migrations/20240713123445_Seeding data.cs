using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraveLog.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Egypt" },
                    { 2, null, "Sweden" },
                    { 3, null, "India" }
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, "The Great Pyramids of Giza", "~/images/Egypt/Pyramids.jpg", "Pyramids" },
                    { 2, 1, "A large temple complex in Luxor", "~/images/Egypt/Karnak Temple.jpg", "Karnak Temple" },
                    { 3, 1, "The mortuary temple of Hatshepsut", "~/images/Egypt/Hatshepsut Temple.jpg", "Hatshepsut Temple" },
                    { 4, 2, "A maritime museum in Stockholm", "~/images/Sweden/Vasa Museum.jpg", "Vasa Museum" },
                    { 5, 2, "A medieval castle in Kalmar", "~/images/Sweden/Kalmar Castle.jpg", "Kalmar Castle" },
                    { 6, 3, "A palace in Jaipur", "~/images/India/Amber Palace.jpg", "Amber Palace" },
                    { 7, 3, "A mausoleum in Agra", "~/images/India/Taj Mahal.jpg", "Taj Mahal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
