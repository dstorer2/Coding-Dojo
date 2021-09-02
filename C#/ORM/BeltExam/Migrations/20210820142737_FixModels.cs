using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class FixModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Gatherings_GatheringId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "WeddingId",
                table: "Attendances");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Gatherings",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "GatheringId",
                table: "Attendances",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Gatherings_GatheringId",
                table: "Attendances",
                column: "GatheringId",
                principalTable: "Gatherings",
                principalColumn: "GatheringId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Gatherings_GatheringId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Gatherings");

            migrationBuilder.AlterColumn<int>(
                name: "GatheringId",
                table: "Attendances",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "WeddingId",
                table: "Attendances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Gatherings_GatheringId",
                table: "Attendances",
                column: "GatheringId",
                principalTable: "Gatherings",
                principalColumn: "GatheringId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
