using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarketAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_customers_customer_id",
                table: "admins");

            migrationBuilder.DropForeignKey(
                name: "FK_admins_products_product_id",
                table: "admins");

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "customer_id",
                table: "admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "customer_id", "product_id" },
                values: new object[] { null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_admins_customers_customer_id",
                table: "admins",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_admins_products_product_id",
                table: "admins",
                column: "product_id",
                principalTable: "products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_customers_customer_id",
                table: "admins");

            migrationBuilder.DropForeignKey(
                name: "FK_admins_products_product_id",
                table: "admins");

            migrationBuilder.AlterColumn<int>(
                name: "product_id",
                table: "admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "customer_id",
                table: "admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "customer_id", "product_id" },
                values: new object[] { 0, 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_admins_customers_customer_id",
                table: "admins",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_admins_products_product_id",
                table: "admins",
                column: "product_id",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
