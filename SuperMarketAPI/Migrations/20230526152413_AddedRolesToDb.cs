using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperMarketAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48587e71-c6f4-4f39-96a7-545d1c38a1b7", "1ba3db40-b841-4ac5-b1f3-df546afae14b", "Administrator", "ADMINISTRATOR" },
                    { "9da1d380-c430-44fb-9b52-be120e475c06", "f4046c49-1f31-48a8-a5e2-51836d90257c", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48587e71-c6f4-4f39-96a7-545d1c38a1b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9da1d380-c430-44fb-9b52-be120e475c06");
        }
    }
}
