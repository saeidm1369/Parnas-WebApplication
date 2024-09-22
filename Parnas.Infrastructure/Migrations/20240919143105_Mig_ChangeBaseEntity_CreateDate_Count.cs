using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parnas.Infrastructure.Migrations
{
    public partial class Mig_ChangeBaseEntity_CreateDate_Count : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "SSDs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SSDs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Rams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Rams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Powers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Powers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "MotherBoards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "MotherBoards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Monitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Monitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "HDDs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "HDDs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "GraphicCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "GraphicCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Gamings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Gamings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "FanCases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "FanCases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CPUs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Coolings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Coolings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Cases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Accessories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "SSDs");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SSDs");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "HDDs");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "HDDs");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "GraphicCards");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "GraphicCards");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Gamings");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Gamings");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "FanCases");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "FanCases");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Coolings");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Coolings");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Accessories");
        }
    }
}
