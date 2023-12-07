using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace newWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class FilmCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Autor = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Remarks = table.Column<string>(type: "TEXT", nullable: true),
                    Commande = table.Column<int>(type: "INTEGER", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Duree = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "Id", "Autor", "Commande", "CreatedAt", "CreatedBy", "DeletedAt", "Description", "Duree", "Genre", "Price", "PublishDate", "Remarks", "Stock", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "MonPremierAuteur", 20, new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5863), "", new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5889), "Pas mal", new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animé", 15m, new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "Mon Premier Film", new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5887), "" },
                    { 2, "MonDeuxiemeAuteur", 5, new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5899), "", new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5902), "Tres bien", new DateTime(2014, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animé", 15m, new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Mon Deuxieme Film", new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5900), "" },
                    { 3, "MonTroisiemeAuteur", 28, new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5907), "", new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5910), "OK", new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action", 35m, new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "Mon Troisieme Film", new DateTime(2023, 12, 7, 11, 28, 49, 119, DateTimeKind.Local).AddTicks(5909), "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6284), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6287), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6297), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6300), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 12, 6, 12, 45, 20, 202, DateTimeKind.Local).AddTicks(6305) });
        }
    }
}
