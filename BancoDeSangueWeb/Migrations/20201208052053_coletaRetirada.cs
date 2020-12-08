using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeSangueWeb.Migrations
{
    public partial class coletaRetirada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true),
                    DoadorId = table.Column<int>(type: "int", nullable: true),
                    TipoSanguineoId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        name: "FK_Coleta_TipoSanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "TipoSanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Retirada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalId = table.Column<int>(type: "int", nullable: true),
                    TipoSanguineoId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        name: "FK_Retirada_TipoSanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "TipoSanguineo",
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
        }
    }
}
