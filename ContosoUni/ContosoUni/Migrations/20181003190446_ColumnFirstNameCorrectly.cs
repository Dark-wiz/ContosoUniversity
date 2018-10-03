using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUni.Migrations
{
    public partial class ColumnFirstNameCorrectly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "First Name",
                table: "Student",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "First Name");
        }
    }
}
