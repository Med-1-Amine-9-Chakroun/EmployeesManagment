using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Nr_Personne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Nom_Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activer = table.Column<bool>(type: "bit", nullable: false),
                    Matricule = table.Column<int>(type: "int", nullable: false),
                    Nom_Groupe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nr_Groupe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Technicien = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Nr_Personne);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
