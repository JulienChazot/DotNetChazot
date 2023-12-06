using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace newWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Autor", "CreatedAt", "CreatedBy", "DeletedAt", "Description", "Genre", "Price", "PublishDate", "Remarks", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Christian Nagel", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5530), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5589), "A true masterclass in C# and .NET programming", "Software", 50m, new DateTime(2016, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Professional C# 6 and .NET Core 1.0", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5588), "" },
                    { 2, "Christian Nagel", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5600), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5604), "A true masterclass in C# and .NET programming", "Software", 50m, new DateTime(2018, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Professional C# 7 and .NET Core 2.0", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5602), "" },
                    { 3, "Christian Nagel", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5608), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5611), "A true masterclass in C# and .NET programming", "Software", 50m, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Professional C# 8 and .NET Core 3.0", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5610), "" },
                    { 4, "Christian Nagel", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5617), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5620), "A true masterclass in C# and .NET programming", "Software", 50m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Professional C# 9 and .NET 5", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5619), "" },
                    { 5, "Perkins, Reid, and Hammer", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5623), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5627), "The perfect guide to Visual C#", "Software", 45m, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beginning Visual C# 2019", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5625), "" },
                    { 6, "Andrew Troelsen", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5630), "", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5633), "The ultimate C# resource", "Software", 50m, new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pro C# 7", new DateTime(2023, 12, 6, 12, 21, 35, 645, DateTimeKind.Local).AddTicks(5632), "" }
                });
        }
    }
}
