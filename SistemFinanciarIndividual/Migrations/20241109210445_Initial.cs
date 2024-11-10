using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemFinanciarIndividual.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    idCategorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.idCategorie);
                });

            migrationBuilder.CreateTable(
                name: "Tranzactii",
                columns: table => new
                {
                    IdTranzactie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCategorie = table.Column<int>(type: "int", nullable: false),
                    CategorieidCategorie = table.Column<int>(type: "int", nullable: false),
                    Valoare = table.Column<int>(type: "int", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(75)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tranzactii", x => x.IdTranzactie);
                    table.ForeignKey(
                        name: "FK_Tranzactii_Categorie_CategorieidCategorie",
                        column: x => x.CategorieidCategorie,
                        principalTable: "Categorie",
                        principalColumn: "idCategorie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactii_CategorieidCategorie",
                table: "Tranzactii",
                column: "CategorieidCategorie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tranzactii");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
