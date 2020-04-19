using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GridSample.Migrations
{
    public partial class GridTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestListDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestUnit = table.Column<float>(name: "Test Unit", nullable: false),
                    TestNormalValue = table.Column<float>(name: "Test Normal Value", nullable: false),
                    TestParameter = table.Column<bool>(name: "Test Parameter", nullable: false),
                    ValidationDate = table.Column<DateTime>(name: "Validation Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestListDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(name: "Test ID", nullable: false),
                    CategoryName = table.Column<string>(name: "Category Name", nullable: false),
                    TestShortName = table.Column<string>(name: "Test Short Name", nullable: false),
                    TestName = table.Column<string>(name: "Test Name", nullable: false),
                    TestPrice = table.Column<double>(name: "Test Price", nullable: false),
                    CurrentlyPerforming = table.Column<bool>(name: "Currently Performing", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestLists", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestListDetails");

            migrationBuilder.DropTable(
                name: "TestLists");
        }
    }
}
