using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TuningPartsApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Founder = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Production_Year = table.Column<int>(type: "INTEGER", nullable: false),
                    BrandId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Description", "Founder", "Name" },
                values: new object[,]
                {
                    { new Guid("4998c894-a8dc-4ab8-82d9-c8b8ae204f1f"), "German multinational company which currently produces luxury automobiles and motorcycles.", "Franz Josef Popp, Karl Rapp, and Camillo Castiglioni", "BMW Motorrad" },
                    { new Guid("54b9c9d6-2007-45eb-80a1-e5958e8170f4"), "Japanese multinational conglomerate", "Soichiro Honda", "Honda" },
                    { new Guid("54df43e4-aa1c-4bcc-aa70-8c9c45a56be3"), "British motorcycle manufacturing company, based originally in Coventry and then in Meriden.", "John Bloor", "Triumph" },
                    { new Guid("6b761548-e654-4a48-8ef0-bb9d5e62cfaf"), "The coolest motor bike", "Hr Ducati", "Ducati" },
                    { new Guid("6cb4144c-d4e5-4298-8330-1b21d0c2d5e5"), "Japanese multinational corporation headquartered in Iwata, Shizuoka, Japan.", "Torakusu Yamaha", "Yamaha" },
                    { new Guid("8d8bde88-0035-42c8-af59-97abebd26f45"), "Iconic American motorcycle manufacturer", "William S. Harley and Arthur Davidson", "Harley-Davidson" },
                    { new Guid("a180584a-8c54-407a-a2e4-1786bb952eab"), "Italian motorcycle company, one of the marques owned by Piaggio.", "Alberto Beggio", "Aprilia" },
                    { new Guid("c7d98550-7f9b-4365-b862-148b6723a6f2"), "Japanese multinational corporation known for motorcycles, heavy equipment, aerospace and defense equipment, rolling stock and ships.", "Shozo Kawasaki", "Kawasaki" },
                    { new Guid("ca1ec02a-5b48-4aff-8e48-f618a7577627"), "Japanese multinational corporation headquartered in Minami-ku, Hamamatsu, Japan.", "Michio Suzuki", "Suzuki" },
                    { new Guid("f5c281a1-af56-4b1b-811d-8c65f52eb056"), "American brand of motorcycles originally produced from 1901 to 1953 in Springfield, Massachusetts, United States.", "George M. Hendee, Oscar Hedstrom", "Indian Motorcycle" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
