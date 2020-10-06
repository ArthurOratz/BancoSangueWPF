using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoSangueWPF.Migrations
{
    public partial class mudancaColetaRetirada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Doador_DoadorId",
                table: "EstoqueSangue");

            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Funcionario_FuncionarioId",
                table: "EstoqueSangue");

            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Hospital_HospitalId",
                table: "EstoqueSangue");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueSangue_DoadorId",
                table: "EstoqueSangue");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueSangue_FuncionarioId",
                table: "EstoqueSangue");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueSangue_HospitalId",
                table: "EstoqueSangue");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "EstoqueSangue");

            migrationBuilder.DropColumn(
                name: "DoadorId",
                table: "EstoqueSangue");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "EstoqueSangue");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "EstoqueSangue");

            migrationBuilder.DropColumn(
                name: "Retirada_Data",
                table: "EstoqueSangue");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "EstoqueSangue");

            migrationBuilder.CreateTable(
                name: "Coleta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    DoadorId = table.Column<int>(nullable: true),
                    FuncionarioId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    TipoSanguineoId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coleta_Doador_DoadorId",
                        column: x => x.DoadorId,
                        principalTable: "Doador",
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
                    HospitalId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    TipoSanguineoId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coleta");

            migrationBuilder.DropTable(
                name: "Retirada");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "EstoqueSangue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoadorId",
                table: "EstoqueSangue",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "EstoqueSangue",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "EstoqueSangue",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Retirada_Data",
                table: "EstoqueSangue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HospitalId",
                table: "EstoqueSangue",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueSangue_DoadorId",
                table: "EstoqueSangue",
                column: "DoadorId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueSangue_FuncionarioId",
                table: "EstoqueSangue",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueSangue_HospitalId",
                table: "EstoqueSangue",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueSangue_Doador_DoadorId",
                table: "EstoqueSangue",
                column: "DoadorId",
                principalTable: "Doador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueSangue_Funcionario_FuncionarioId",
                table: "EstoqueSangue",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueSangue_Hospital_HospitalId",
                table: "EstoqueSangue",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
