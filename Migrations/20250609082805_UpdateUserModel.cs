using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkProgresses_Users_UserId1",
                table: "WorkProgresses");

            migrationBuilder.DropIndex(
                name: "IX_WorkProgresses_UserId1",
                table: "WorkProgresses");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "WorkProgresses");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "WorkProgresses");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "WorkProgresses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Urgency",
                table: "WorkProgresses",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "WorkProgresses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ProgressStage",
                table: "WorkProgresses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkProgresses_UserId",
                table: "WorkProgresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkProgresses_Users_UserId",
                table: "WorkProgresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkProgresses_Users_UserId",
                table: "WorkProgresses");

            migrationBuilder.DropIndex(
                name: "IX_WorkProgresses_UserId",
                table: "WorkProgresses");

            migrationBuilder.DropColumn(
                name: "ProgressStage",
                table: "WorkProgresses");

            migrationBuilder.DropColumn(
                name: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "WorkProgresses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Urgency",
                table: "WorkProgresses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "WorkProgresses",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "WorkProgresses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "WorkProgresses",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkProgresses_UserId1",
                table: "WorkProgresses",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkProgresses_Users_UserId1",
                table: "WorkProgresses",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
