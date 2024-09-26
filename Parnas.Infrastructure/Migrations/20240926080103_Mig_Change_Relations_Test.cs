using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parnas.Infrastructure.Migrations
{
    public partial class Mig_Change_Relations_Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessoryImages");

            migrationBuilder.AddColumn<int>(
                name: "AccessoryId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_AccessoryId",
                table: "ProductImages",
                column: "AccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductImageId",
                table: "ProductImages",
                column: "ProductImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Accessories_AccessoryId",
                table: "ProductImages",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_ProductImageId",
                table: "ProductImages",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Accessories_AccessoryId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_AccessoryId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "AccessoryId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "ProductImages");

            migrationBuilder.CreateTable(
                name: "AccessoryImages",
                columns: table => new
                {
                    AccessoryId = table.Column<int>(type: "int", nullable: false),
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryImages", x => new { x.AccessoryId, x.ProductImageId });
                    table.ForeignKey(
                        name: "FK_AccessoryImages_Accessories_AccessoryId",
                        column: x => x.AccessoryId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessoryImages_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessoryImages_ProductImageId",
                table: "AccessoryImages",
                column: "ProductImageId");
        }
    }
}
