using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryAbbreviation", "CountryName" },
                values: new object[] { 1, "JM", "Jamaica" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryAbbreviation", "CountryName" },
                values: new object[] { 2, "BS", "Bahamas" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryAbbreviation", "CountryName" },
                values: new object[] { 3, "CI", "Cayman Island" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CountryId", "HotelAddress", "HotelName", "HotelRating" },
                values: new object[] { 1, 1, "Negril", "Sandals Resort and Spa", 4.5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CountryId", "HotelAddress", "HotelName", "HotelRating" },
                values: new object[] { 2, 2, "Nassua", "Grand Palldium", 4.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CountryId", "HotelAddress", "HotelName", "HotelRating" },
                values: new object[] { 3, 3, "George Town", "Comfort Suites", 4.2999999999999998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);
        }
    }
}
