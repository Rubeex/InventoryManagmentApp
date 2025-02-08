using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagmentApp.Migrations
{
    /// <inheritdoc />
    public partial class NombreDeLaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_salesProducts",
                table: "salesProducts");

            migrationBuilder.DropIndex(
                name: "IX_salesProducts_SaleId",
                table: "salesProducts");

            migrationBuilder.DropColumn(
                name: "SalesId",
                table: "salesProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesProducts",
                table: "salesProducts",
                columns: new[] { "SaleId", "ProductId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_salesProducts",
                table: "salesProducts");

            migrationBuilder.AddColumn<int>(
                name: "SalesId",
                table: "salesProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesProducts",
                table: "salesProducts",
                columns: new[] { "SalesId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_salesProducts_SaleId",
                table: "salesProducts",
                column: "SaleId");
        }
    }
}
