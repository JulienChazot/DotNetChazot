using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Books",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5530), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5588), "" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5600), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5602), "" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5608), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5610), "" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5617), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5619), "" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5623), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5627), new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5625), "" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "DeletedAt", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5630), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5633), new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5632), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Books",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);
        }
    }
}
