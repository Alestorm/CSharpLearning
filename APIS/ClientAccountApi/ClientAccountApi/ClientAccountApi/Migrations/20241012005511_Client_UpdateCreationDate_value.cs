using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientAccountApi.Migrations
{
    /// <inheritdoc />
    public partial class Client_UpdateCreationDate_value : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Clients",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 11, 20, 55, 11, 238, DateTimeKind.Local).AddTicks(2965),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 11, 20, 55, 11, 238, DateTimeKind.Local).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 10, 9, 22, 47, 50, 147, DateTimeKind.Local).AddTicks(3634));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Clients",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 10, 11, 20, 55, 11, 238, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 9, 22, 47, 50, 147, DateTimeKind.Local).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 10, 11, 20, 55, 11, 238, DateTimeKind.Local).AddTicks(4037));
        }
    }
}
