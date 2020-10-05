using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoSangueWPF.Migrations
{
    public partial class TabEstoqueSangueNoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Retirada_Hospital_HospitalId",
                table: "Retirada");

            migrationBuilder.DropForeignKey(
                name: "FK_Retirada_Tipo_Sanguineo_TipoSanguineoId",
                table: "Retirada");

            migrationBuilder.DropTable(
                name: "Coleta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Retirada",
                table: "Retirada");

            migrationBuilder.RenameTable(
                name: "Retirada",
                newName: "EstoqueSangue");

            migrationBuilder.RenameIndex(
                name: "IX_Retirada_TipoSanguineoId",
                table: "EstoqueSangue",
                newName: "IX_EstoqueSangue_TipoSanguineoId");

            migrationBuilder.RenameIndex(
                name: "IX_Retirada_HospitalId",
                table: "EstoqueSangue",
                newName: "IX_EstoqueSangue_HospitalId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "EstoqueSangue",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "DoadorId",
                table: "EstoqueSangue",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "EstoqueSangue",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "EstoqueSangue",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Retirada_Data",
                table: "EstoqueSangue",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstoqueSangue",
                table: "EstoqueSangue",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueSangue_DoadorId",
                table: "EstoqueSangue",
                column: "DoadorId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueSangue_FuncionarioId",
                table: "EstoqueSangue",
                column: "FuncionarioId");

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
                name: "FK_EstoqueSangue_Tipo_Sanguineo_TipoSanguineoId",
                table: "EstoqueSangue",
                column: "TipoSanguineoId",
                principalTable: "Tipo_Sanguineo",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Doador_DoadorId",
                table: "EstoqueSangue");

            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Funcionario_FuncionarioId",
                table: "EstoqueSangue");

            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Tipo_Sanguineo_TipoSanguineoId",
                table: "EstoqueSangue");

            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Hospital_HospitalId",
                table: "EstoqueSangue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstoqueSangue",
                table: "EstoqueSangue");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueSangue_DoadorId",
                table: "EstoqueSangue");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueSangue_FuncionarioId",
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

            migrationBuilder.RenameTable(
                name: "EstoqueSangue",
                newName: "Retirada");

            migrationBuilder.RenameIndex(
                name: "IX_EstoqueSangue_HospitalId",
                table: "Retirada",
                newName: "IX_Retirada_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_EstoqueSangue_TipoSanguineoId",
                table: "Retirada",
                newName: "IX_Retirada_TipoSanguineoId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Retirada",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Retirada",
                table: "Retirada",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Coleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoadorId = table.Column<int>(type: "int", nullable: true),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    TipoSanguineoId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Retirada_Hospital_HospitalId",
                table: "Retirada",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Retirada_Tipo_Sanguineo_TipoSanguineoId",
                table: "Retirada",
                column: "TipoSanguineoId",
                principalTable: "Tipo_Sanguineo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
