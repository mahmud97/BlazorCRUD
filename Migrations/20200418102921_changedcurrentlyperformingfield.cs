using Microsoft.EntityFrameworkCore.Migrations;

namespace GridSample.Migrations
{
    public partial class changedcurrentlyperformingfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Currently Performing",
                table: "TestLists",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Currently Performing",
                table: "TestLists",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
