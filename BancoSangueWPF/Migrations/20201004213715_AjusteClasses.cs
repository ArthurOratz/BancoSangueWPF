using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoSangueWPF.Migrations
{
    public partial class AjusteClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo_sanguineo",
                table: "Doadores");

            migrationBuilder.AlterColumn<float>(
                name: "Peso",
                table: "Doadores",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TipoSanguineoId",
                table: "Doadores",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Nome_hospital = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false),
                    Nome_responsavel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Sanguineo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Fator_RH = table.Column<string>(nullable: true),
                    Tipo_sanguineo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Sanguineo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coleta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    TipoSanguineoId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    DoadorId = table.Column<int>(nullable: true),
                    FuncionarioId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coleta_Doadores_DoadorId",
                        column: x => x.DoadorId,
                        principalTable: "Doadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coleta_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coleta_Tipo_Sanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "Tipo_Sanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Retirada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    TipoSanguineoId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    HospitalId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retirada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Retirada_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Retirada_Tipo_Sanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "Tipo_Sanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doadores_TipoSanguineoId",
                table: "Doadores",
                column: "TipoSanguineoId");

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_DoadorId",
                table: "Coleta",
                column: "DoadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_FuncionarioId",
                table: "Coleta",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_TipoSanguineoId",
                table: "Coleta",
                column: "TipoSanguineoId");

            migrationBuilder.CreateIndex(
                name: "IX_Retirada_HospitalId",
                table: "Retirada",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Retirada_TipoSanguineoId",
                table: "Retirada",
                column: "TipoSanguineoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doadores_Tipo_Sanguineo_TipoSanguineoId",
                table: "Doadores",
                column: "TipoSanguineoId",
                principalTable: "Tipo_Sanguineo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_Tipo_Sanguineo_TipoSanguineoId",
                table: "Doadores");

            migrationBuilder.DropTable(
                name: "Coleta");

            migrationBuilder.DropTable(
                name: "Retirada");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "Tipo_Sanguineo");

            migrationBuilder.DropIndex(
                name: "IX_Doadores_TipoSanguineoId",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "TipoSanguineoId",
                table: "Doadores");

            migrationBuilder.AlterColumn<int>(
                name: "Peso",
                table: "Doadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<string>(
                name: "Tipo_sanguineo",
                table: "Doadores",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
