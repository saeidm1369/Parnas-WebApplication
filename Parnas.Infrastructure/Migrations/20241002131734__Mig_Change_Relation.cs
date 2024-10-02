using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parnas.Infrastructure.Migrations
{
    public partial class _Mig_Change_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_AccessoryImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "AccessoryImage_ProductImageId",
                table: "ProductImages",
                newName: "ProductImageId1");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_AccessoryImage_ProductImageId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductImageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_ProductImageId1",
                table: "ProductImages",
                column: "ProductImageId1",
                principalTable: "ProductImages",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_ProductImageId1",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "ProductImageId1",
                table: "ProductImages",
                newName: "AccessoryImage_ProductImageId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductImageId1",
                table: "ProductImages",
                newName: "IX_ProductImages_AccessoryImage_ProductImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_AccessoryImage_ProductImageId",
                table: "ProductImages",
                column: "AccessoryImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");
        }
    }
}
