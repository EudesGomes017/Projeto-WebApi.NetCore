using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.NetCore.Migrations
{
    public partial class HeroisBatalhas_Identidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herois_Batalhas_BatalhaId",
                table: "Herois");

            migrationBuilder.DropIndex(
                name: "IX_Herois_BatalhaId",
                table: "Herois");

            migrationBuilder.DropColumn(
                name: "BatalhaId",
                table: "Herois");

            migrationBuilder.AddColumn<int>(
                name: "BatalhaId",
                table: "Armas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HeroisBatalhas",
                columns: table => new
                {
                    HeroiId = table.Column<int>(type: "int", nullable: false),
                    BatalhaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroisBatalhas", x => new { x.BatalhaId, x.HeroiId });
                    table.ForeignKey(
                        name: "FK_HeroisBatalhas_Batalhas_BatalhaId",
                        column: x => x.BatalhaId,
                        principalTable: "Batalhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroisBatalhas_Herois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentidadeSecretas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeReal = table.Column<int>(type: "int", nullable: false),
                    HeroiId = table.Column<int>(type: "int", nullable: false),
                    Heroi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentidadeSecretas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentidadeSecretas_Herois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_BatalhaId",
                table: "Armas",
                column: "BatalhaId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroisBatalhas_HeroiId",
                table: "HeroisBatalhas",
                column: "HeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentidadeSecretas_HeroiId",
                table: "IdentidadeSecretas",
                column: "HeroiId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Batalhas_BatalhaId",
                table: "Armas",
                column: "BatalhaId",
                principalTable: "Batalhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Batalhas_BatalhaId",
                table: "Armas");

            migrationBuilder.DropTable(
                name: "HeroisBatalhas");

            migrationBuilder.DropTable(
                name: "IdentidadeSecretas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_BatalhaId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "BatalhaId",
                table: "Armas");

            migrationBuilder.AddColumn<int>(
                name: "BatalhaId",
                table: "Herois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Herois_BatalhaId",
                table: "Herois",
                column: "BatalhaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Herois_Batalhas_BatalhaId",
                table: "Herois",
                column: "BatalhaId",
                principalTable: "Batalhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
