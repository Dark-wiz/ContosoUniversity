﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUni.Migrations
{
    public partial class ColumnFirstName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Person",
                newName: "First Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "First Name",
                table: "Person",
                newName: "FirstMidName");
        }
    }
}
