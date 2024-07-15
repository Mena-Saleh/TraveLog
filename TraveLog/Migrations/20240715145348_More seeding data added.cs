using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraveLog.Migrations
{
    /// <inheritdoc />
    public partial class Moreseedingdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Japan" },
                    { 5, "Brazil" },
                    { 6, "Australia" }
                });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The Great Pyramids of Giza, a wonder of ancient world.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A large temple complex in Luxor, dedicated to Amun-Ra.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The mortuary temple of Hatshepsut, located in Deir el-Bahari.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, "A valley in Luxor where tombs were constructed for the Pharaohs.", "Valley of the Kings.jpg", "Valley of the Kings" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, "Massive rock temples at Abu Simbel, built by Ramses II.", "Abu Simbel Temples.jpg", "Abu Simbel Temples" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, "A maritime museum in Stockholm, home to the 17th-century ship Vasa.", "Vasa Museum.jpg", "Vasa Museum" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, "A medieval castle in Kalmar, with a history dating back to 12th century.", "Kalmar Castle.jpg", "Kalmar Castle" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 8, 2, "The old town of Stockholm, known for its cobblestone streets and colorful buildings.", "Gamla Stan.jpg", "Gamla Stan" },
                    { 9, 2, "A royal palace in Stockholm, the private residence of the Swedish royal family.", "Drottningholm Palace.jpg", "Drottningholm Palace" },
                    { 10, 3, "A palace in Jaipur, known for its artistic Hindu-style elements.", "Amber Palace.jpg", "Amber Palace" },
                    { 11, 3, "A mausoleum in Agra, built by Emperor Shah Jahan.", "Taj Mahal.jpg", "Taj Mahal" },
                    { 12, 3, "A minaret and victory tower in Delhi, one of the tallest in India.", "Qutub Minar.jpg", "Qutub Minar" },
                    { 13, 3, "A historical palace in the city of Mysore, known for its architectural grandeur.", "Mysore Palace.jpg", "Mysore Palace" },
                    { 14, 4, "An iconic volcano and the highest peak in Japan, a popular climbing spot.", "Mount Fuji.jpg", "Mount Fuji" },
                    { 15, 4, "The Golden Pavilion, a Zen Buddhist temple in Kyoto.", "Kinkakuji.jpg", "Kinkaku-ji" },
                    { 16, 4, "A communications and observation tower in Tokyo, inspired by the Eiffel Tower.", "Tokyo Tower.jpg", "Tokyo Tower" },
                    { 17, 5, "An iconic statue of Jesus Christ in Rio de Janeiro.", "Christ the Redeemer.jpg", "Christ the Redeemer" },
                    { 18, 5, "A massive waterfall system on the border of Brazil and Argentina.", "Iguazu Falls.jpg", "Iguazu Falls" },
                    { 19, 5, "A peak situated in Rio de Janeiro, offering panoramic views.", "Sugarloaf Mountain.jpg", "Sugarloaf Mountain" },
                    { 20, 6, "An iconic performing arts center in Sydney, known for its unique design.", "Sydney Opera House.jpg", "Sydney Opera House" },
                    { 21, 6, "The world's largest coral reef system, located in the Coral Sea.", "Great Barrier Reef.jpg", "Great Barrier Reef" },
                    { 22, 6, "A massive sandstone monolith in the heart of the Northern Territory.", "Uluru.jpg", "Uluru" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The Great Pyramids of Giza");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A large temple complex in Luxor");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The mortuary temple of Hatshepsut");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, "A maritime museum in Stockholm", "Vasa Museum.jpg", "Vasa Museum" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, "A medieval castle in Kalmar", "Kalmar Castle.jpg", "Kalmar Castle" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 3, "A palace in Jaipur", "Amber Palace.jpg", "Amber Palace" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 3, "A mausoleum in Agra", "Taj Mahal.jpg", "Taj Mahal" });
        }
    }
}
