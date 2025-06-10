using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkProgressTable_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkProgresses_Users_UserId",
                table: "WorkProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkProgresses",
                table: "WorkProgresses");

            migrationBuilder.RenameTable(
                name: "WorkProgresses",
                newName: "WorkProgress");

            migrationBuilder.RenameIndex(
                name: "IX_WorkProgresses_UserId",
                table: "WorkProgress",
                newName: "IX_WorkProgress_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkProgress",
                table: "WorkProgress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkProgress_Users_UserId",
                table: "WorkProgress",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkProgress_Users_UserId",
                table: "WorkProgress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkProgress",
                table: "WorkProgress");

            migrationBuilder.RenameTable(
                name: "WorkProgress",
                newName: "WorkProgresses");

            migrationBuilder.RenameIndex(
                name: "IX_WorkProgress_UserId",
                table: "WorkProgresses",
                newName: "IX_WorkProgresses_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkProgresses",
                table: "WorkProgresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkProgresses_Users_UserId",
                table: "WorkProgresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
