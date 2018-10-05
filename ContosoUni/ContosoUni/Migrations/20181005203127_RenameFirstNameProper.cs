using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUni.Migrations
{
    public partial class RenameFirstNameProper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Person",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Person",
                newName: "FirstName");
        }
    }
}
