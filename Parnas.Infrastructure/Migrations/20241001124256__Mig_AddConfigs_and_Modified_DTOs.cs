using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parnas.Infrastructure.Migrations
{
    public partial class _Mig_AddConfigs_and_Modified_DTOs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Categories_CategoryId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Coolings_Categories_CategoryId",
                table: "Coolings");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_Categories_CategoryId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_FanCases_Categories_CategoryId",
                table: "FanCases");

            migrationBuilder.DropForeignKey(
                name: "FK_Gamings_Categories_CategoryId",
                table: "Gamings");

            migrationBuilder.DropForeignKey(
                name: "FK_GraphicCards_Categories_CategoryId",
                table: "GraphicCards");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_Categories_CategoryId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_MotherBoards_Categories_CategoryId",
                table: "MotherBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Categories_CategoryId",
                table: "Powers");

            migrationBuilder.DropForeignKey(
                name: "FK_Rams_Categories_CategoryId",
                table: "Rams");

            migrationBuilder.DropForeignKey(
                name: "FK_SSDs_Categories_CategoryId",
                table: "SSDs");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "SSDs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Rams",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "AccessoryImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CPUId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CPUImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaseId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaseImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComputerMonitorId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComputerMonitorImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoolingId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoolingImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FanCaseId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FanCaseImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GamingId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GamingImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GraphicCardId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GraphicCardImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HDDId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HDDImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotherBoardId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotherBoardImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RamId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RamImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SSDId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SSDImage_ProductImageId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Powers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "MotherBoards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Monitors",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "HDDs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "GraphicCards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Gamings",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "FanCases",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "CPUs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Coolings",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Cases",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_AccessoryImage_ProductImageId",
                table: "ProductImages",
                column: "AccessoryImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CaseId",
                table: "ProductImages",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CaseImage_ProductImageId",
                table: "ProductImages",
                column: "CaseImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ComputerMonitorId",
                table: "ProductImages",
                column: "ComputerMonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ComputerMonitorImage_ProductImageId",
                table: "ProductImages",
                column: "ComputerMonitorImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CoolingId",
                table: "ProductImages",
                column: "CoolingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CoolingImage_ProductImageId",
                table: "ProductImages",
                column: "CoolingImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CPUId",
                table: "ProductImages",
                column: "CPUId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CPUImage_ProductImageId",
                table: "ProductImages",
                column: "CPUImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_FanCaseId",
                table: "ProductImages",
                column: "FanCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_FanCaseImage_ProductImageId",
                table: "ProductImages",
                column: "FanCaseImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_GamingId",
                table: "ProductImages",
                column: "GamingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_GamingImage_ProductImageId",
                table: "ProductImages",
                column: "GamingImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_GraphicCardId",
                table: "ProductImages",
                column: "GraphicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_GraphicCardImage_ProductImageId",
                table: "ProductImages",
                column: "GraphicCardImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_HDDId",
                table: "ProductImages",
                column: "HDDId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_HDDImage_ProductImageId",
                table: "ProductImages",
                column: "HDDImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_MotherBoardId",
                table: "ProductImages",
                column: "MotherBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_MotherBoardImage_ProductImageId",
                table: "ProductImages",
                column: "MotherBoardImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_PowerId",
                table: "ProductImages",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_RamId",
                table: "ProductImages",
                column: "RamId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_RamImage_ProductImageId",
                table: "ProductImages",
                column: "RamImage_ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_SSDId",
                table: "ProductImages",
                column: "SSDId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_SSDImage_ProductImageId",
                table: "ProductImages",
                column: "SSDImage_ProductImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Categories_CategoryId",
                table: "Cases",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coolings_Categories_CategoryId",
                table: "Coolings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_Categories_CategoryId",
                table: "CPUs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FanCases_Categories_CategoryId",
                table: "FanCases",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gamings_Categories_CategoryId",
                table: "Gamings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GraphicCards_Categories_CategoryId",
                table: "GraphicCards",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_Categories_CategoryId",
                table: "HDDs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MotherBoards_Categories_CategoryId",
                table: "MotherBoards",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Categories_CategoryId",
                table: "Powers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Cases_CaseId",
                table: "ProductImages",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Coolings_CoolingId",
                table: "ProductImages",
                column: "CoolingId",
                principalTable: "Coolings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_CPUs_CPUId",
                table: "ProductImages",
                column: "CPUId",
                principalTable: "CPUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_FanCases_FanCaseId",
                table: "ProductImages",
                column: "FanCaseId",
                principalTable: "FanCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Gamings_GamingId",
                table: "ProductImages",
                column: "GamingId",
                principalTable: "Gamings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_GraphicCards_GraphicCardId",
                table: "ProductImages",
                column: "GraphicCardId",
                principalTable: "GraphicCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_HDDs_HDDId",
                table: "ProductImages",
                column: "HDDId",
                principalTable: "HDDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Monitors_ComputerMonitorId",
                table: "ProductImages",
                column: "ComputerMonitorId",
                principalTable: "Monitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_MotherBoards_MotherBoardId",
                table: "ProductImages",
                column: "MotherBoardId",
                principalTable: "MotherBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Powers_PowerId",
                table: "ProductImages",
                column: "PowerId",
                principalTable: "Powers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_AccessoryImage_ProductImageId",
                table: "ProductImages",
                column: "AccessoryImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_CaseImage_ProductImageId",
                table: "ProductImages",
                column: "CaseImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_ComputerMonitorImage_ProductImageId",
                table: "ProductImages",
                column: "ComputerMonitorImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_CoolingImage_ProductImageId",
                table: "ProductImages",
                column: "CoolingImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_CPUImage_ProductImageId",
                table: "ProductImages",
                column: "CPUImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_FanCaseImage_ProductImageId",
                table: "ProductImages",
                column: "FanCaseImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_GamingImage_ProductImageId",
                table: "ProductImages",
                column: "GamingImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_GraphicCardImage_ProductImageId",
                table: "ProductImages",
                column: "GraphicCardImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_HDDImage_ProductImageId",
                table: "ProductImages",
                column: "HDDImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_MotherBoardImage_ProductImageId",
                table: "ProductImages",
                column: "MotherBoardImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_RamImage_ProductImageId",
                table: "ProductImages",
                column: "RamImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_SSDImage_ProductImageId",
                table: "ProductImages",
                column: "SSDImage_ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Rams_RamId",
                table: "ProductImages",
                column: "RamId",
                principalTable: "Rams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_SSDs_SSDId",
                table: "ProductImages",
                column: "SSDId",
                principalTable: "SSDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_Categories_CategoryId",
                table: "Rams",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SSDs_Categories_CategoryId",
                table: "SSDs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Categories_CategoryId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Coolings_Categories_CategoryId",
                table: "Coolings");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_Categories_CategoryId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_FanCases_Categories_CategoryId",
                table: "FanCases");

            migrationBuilder.DropForeignKey(
                name: "FK_Gamings_Categories_CategoryId",
                table: "Gamings");

            migrationBuilder.DropForeignKey(
                name: "FK_GraphicCards_Categories_CategoryId",
                table: "GraphicCards");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_Categories_CategoryId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_MotherBoards_Categories_CategoryId",
                table: "MotherBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Categories_CategoryId",
                table: "Powers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Cases_CaseId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Coolings_CoolingId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_CPUs_CPUId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_FanCases_FanCaseId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Gamings_GamingId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_GraphicCards_GraphicCardId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_HDDs_HDDId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Monitors_ComputerMonitorId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_MotherBoards_MotherBoardId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Powers_PowerId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_AccessoryImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_CaseImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_ComputerMonitorImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_CoolingImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_CPUImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_FanCaseImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_GamingImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_GraphicCardImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_HDDImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_MotherBoardImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_RamImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_SSDImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Rams_RamId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_SSDs_SSDId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Rams_Categories_CategoryId",
                table: "Rams");

            migrationBuilder.DropForeignKey(
                name: "FK_SSDs_Categories_CategoryId",
                table: "SSDs");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_AccessoryImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_CaseId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_CaseImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ComputerMonitorId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ComputerMonitorImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_CoolingId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_CoolingImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_CPUId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_CPUImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_FanCaseId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_FanCaseImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_GamingId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_GamingImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_GraphicCardId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_GraphicCardImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_HDDId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_HDDImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_MotherBoardId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_MotherBoardImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_PowerId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_RamId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_RamImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_SSDId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_SSDImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "AccessoryImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CPUId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CPUImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CaseId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CaseImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ComputerMonitorId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ComputerMonitorImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CoolingId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CoolingImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "FanCaseId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "FanCaseImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "GamingId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "GamingImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "GraphicCardId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "GraphicCardImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "HDDId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "HDDImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "MotherBoardId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "MotherBoardImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "PowerId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "RamId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "RamImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "SSDId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "SSDImage_ProductImageId",
                table: "ProductImages");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "SSDs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Rams",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Powers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "MotherBoards",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Monitors",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "HDDs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "GraphicCards",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Gamings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "FanCases",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "CPUs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Coolings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Cases",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Categories_CategoryId",
                table: "Cases",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coolings_Categories_CategoryId",
                table: "Coolings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_Categories_CategoryId",
                table: "CPUs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FanCases_Categories_CategoryId",
                table: "FanCases",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gamings_Categories_CategoryId",
                table: "Gamings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GraphicCards_Categories_CategoryId",
                table: "GraphicCards",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_Categories_CategoryId",
                table: "HDDs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Categories_CategoryId",
                table: "Monitors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotherBoards_Categories_CategoryId",
                table: "MotherBoards",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Categories_CategoryId",
                table: "Powers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_Categories_CategoryId",
                table: "Rams",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SSDs_Categories_CategoryId",
                table: "SSDs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
