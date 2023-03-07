using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarketAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdminData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "Id", "Address", "Email", "Img", "Name", "Password", "Phone", "customer_id", "product_id" },
                values: new object[] { 2, "Egypt", "saber@gmail.com", "saber.jpg", "Saber Gomaa", "123", "01095575989", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
