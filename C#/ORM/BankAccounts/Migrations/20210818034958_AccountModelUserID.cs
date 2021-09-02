using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAccounts.Migrations
{
    public partial class AccountModelUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_OwnerUserId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_OwnerUserId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_UserId",
                table: "Accounts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_UserId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_OwnerUserId",
                table: "Accounts",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_OwnerUserId",
                table: "Accounts",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
