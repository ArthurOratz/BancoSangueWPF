using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoSangueWPF.Migrations
{
    public partial class AjusteClassestesteDoador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Doadores_DoadorId",
                table: "Coleta");

            migrationBuilder.DropTable(
                name: "Doadores");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Funcionario");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Funcionario",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Doador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    TipoSanguineoId = table.Column<int>(nullable: true),
                    Peso = table.Column<double>(nullable: false),
                    Sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doador_Tipo_Sanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "Tipo_Sanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doador_TipoSanguineoId",
                table: "Doador",
                column: "TipoSanguineoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Doador_DoadorId",
                table: "Coleta",
                column: "DoadorId",
                principalTable: "Doador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Doador_DoadorId",
                table: "Coleta");

            migrationBuilder.DropTable(
                name: "Doador");

            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Funcionario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Doadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    TipoSanguineoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doadores_Tipo_Sanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "Tipo_Sanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doadores_TipoSanguineoId",
                table: "Doadores",
                column: "TipoSanguineoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Doadores_DoadorId",
                table: "Coleta",
                column: "DoadorId",
                principalTable: "Doadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
