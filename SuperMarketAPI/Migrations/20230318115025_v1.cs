using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarketAPI.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_products_product_id",
                table: "admins");

            migrationBuilder.DropIndex(
                name: "IX_admins_product_id",
                table: "admins");

            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "admins");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_products_AdminId",
                table: "products",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_admins_AdminId",
                table: "products",
                column: "AdminId",
                principalTable: "admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_admins_AdminId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_AdminId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "admins",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 2,
                column: "product_id",
                value: null);

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "Id", "Address", "Email", "Img", "Name", "Password", "Phone", "customer_id", "product_id" },
                values: new object[] { 1, "Egypt", "saber@gmail.com", "saber.jpg", "Saber Gomaa", "123", "01095575989", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_admins_product_id",
                table: "admins",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_admins_products_product_id",
                table: "admins",
                column: "product_id",
                principalTable: "products",
                principalColumn: "Id");
        }
    }
}
