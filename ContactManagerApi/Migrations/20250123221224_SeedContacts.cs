using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactManagerApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedContacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "City", "Email", "Name", "Phone", "PostalCode", "State" },
                values: new object[,]
                {
                    { 3, "123 Main St", "Los Angeles", "johndoe@example.com", "John Doe", "1234567890", "90001", "CA" },
                    { 4, "456 Elm St", "San Francisco", "janesmith@example.com", "Jane Smith", "9876543210", "94101", "CA" },
                    { 5, "789 Oak St", "Seattle", "alicej@example.com", "Alice Johnson", "5551234567", "98101", "WA" },
                    { 6, "321 Pine St", "Denver", "bobb@example.com", "Bob Brown", "4445556666", "80201", "CO" },
                    { 7, "654 Cedar Ave", "Chicago", "emmad@example.com", "Emma Davis", "2223334444", "60601", "IL" },
                    { 8, "987 Birch Rd", "Austin", "williamw@example.com", "William Wilson", "1112223333", "73301", "TX" },
                    { 9, "123 Maple Blvd", "Miami", "oliviam@example.com", "Olivia Martinez", "9998887777", "33101", "FL" },
                    { 10, "456 Spruce Ln", "Boston", "jamesa@example.com", "James Anderson", "8887776666", "02101", "MA" },
                    { 11, "789 Willow Dr", "Phoenix", "sophiag@example.com", "Sophia Garcia", "7776665555", "85001", "AZ" },
                    { 12, "321 Aspen Way", "Las Vegas", "michaelh@example.com", "Michael Hernandez", "6665554444", "89101", "NV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
