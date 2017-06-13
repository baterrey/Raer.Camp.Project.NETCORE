using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Raer_Camp_Project_DEMO.Migrations
{
    public partial class changedOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConcatPhone",
                table: "Orders",
                newName: "ContactPhone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "Orders",
                newName: "ConcatPhone");
        }
    }
}
