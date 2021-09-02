using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class TimeAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Gatherings",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");

            migrationBuilder.AddColumn<string>(
                name: "DurationUnit",
                table: "Gatherings",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationUnit",
                table: "Gatherings");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Gatherings",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
