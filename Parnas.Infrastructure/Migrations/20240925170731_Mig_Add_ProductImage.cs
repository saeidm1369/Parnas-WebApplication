using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parnas.Infrastructure.Migrations
{
    public partial class Mig_Add_ProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "SSDs");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "SSDs");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "HDDs");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "HDDs");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "GraphicCards");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "GraphicCards");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Gamings");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Gamings");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "FanCases");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "FanCases");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Coolings");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Coolings");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Accessories");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessoryImages");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "SSDs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "SSDs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Powers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Powers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Monitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Monitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "HDDs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "HDDs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "GraphicCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "GraphicCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Gamings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Gamings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "FanCases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "FanCases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Coolings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Coolings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Cases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Cases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
