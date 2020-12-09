using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeSangueWeb.Migrations
{
    public partial class CriacaoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoSanguineo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FatorRH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSanguineo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    TipoSanguineoId = table.Column<int>(type: "int", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doador_TipoSanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "TipoSanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstoqueSangue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoSanguineoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueSangue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstoqueSangue_TipoSanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "TipoSanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Retirada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoSanguineoId = table.Column<int>(type: "int", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Retirada_TipoSanguineo_TipoSanguineoId",
                        column: x => x.TipoSanguineoId,
                        principalTable: "TipoSanguineo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoadorId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Coleta_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Doador_TipoSanguineoId",
                table: "Doador",
                column: "TipoSanguineoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueSangue_TipoSanguineoId",
                table: "EstoqueSangue",
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
                name: "EstoqueSangue");

            migrationBuilder.DropTable(
                name: "Retirada");

            migrationBuilder.DropTable(
                name: "Doador");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "TipoSanguineo");
        }
    }
}
