using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d802d4a-d454-4e69-8f85-4d86ba7c2d8f", "aa063dcf-1bcc-4164-a227-350dc9211d4c", "Administrator", "ADMINISTRATOR" },
                    { "fa40e3a3-d3ef-48bd-9b69-22755e384148", "e4c6d783-b3c0-4a73-961d-790edc406a85", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d802d4a-d454-4e69-8f85-4d86ba7c2d8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa40e3a3-d3ef-48bd-9b69-22755e384148");
        }
    }
}
