using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class FilmCreateDeux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Film",
                table: "Film");

            migrationBuilder.RenameTable(
                name: "Film",
                newName: "Films");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1194), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1256), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1260), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1265), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1273), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1276), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1282), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1285), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1289), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1463), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1467), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1476), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1479), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1484), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1487), new DateTime(2023, 12, 7, 11, 39, 57, 760, DateTimeKind.Local).AddTicks(1485) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Film");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Film",
                table: "Film",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2495), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2499), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2502), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2505), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2515), new DateTime(2023, 12, 7, 11, 28, 49, 117, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5889), new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5909) });
        }
    }
}
