using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoSangueWPF.Migrations
{
    public partial class apresentacao0710 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Doador_DoadorId",
                table: "Coleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Funcionario_FuncionarioId",
                table: "Coleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Tipo_Sanguineo_TipoSanguineoId",
                table: "Coleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Doador_Tipo_Sanguineo_TipoSanguineoId",
                table: "Doador");

            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueSangue_Tipo_Sanguineo_TipoSanguineoId",
                table: "EstoqueSangue");

            migrationBuilder.DropForeignKey(
                name: "FK_Retirada_Hospital_HospitalId",
                table: "Retirada");

            migrationBuilder.DropForeignKey(
                name: "FK_Retirada_Tipo_Sanguineo_TipoSanguineoId",
                table: "Retirada");

            migrationBuilder.DropIndex(
                name: "IX_Retirada_TipoSanguineoId",
                table: "Retirada");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueSangue_TipoSanguineoId",
                table: "EstoqueSangue");

            migrationBuilder.DropIndex(
                name: "IX_Doador_TipoSanguineoId",
                table: "Doador");

            migrationBuilder.DropIndex(
                name: "IX_Coleta_TipoSanguineoId",
                table: "Coleta");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoId",
                table: "Retirada",
                newName: "TipoSanguineoID");

            migrationBuilder.RenameColumn(
                name: "HospitalId",
                table: "Retirada",
                newName: "HospitalID");

            migrationBuilder.RenameIndex(
                name: "IX_Retirada_HospitalId",
                table: "Retirada",
                newName: "IX_Retirada_HospitalID");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoId",
                table: "EstoqueSangue",
                newName: "TipoSanguineoID");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoId",
                table: "Doador",
                newName: "TipoSanguineoID");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoId",
                table: "Coleta",
                newName: "TipoSanguineoID");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "Coleta",
                newName: "FuncionarioID");

            migrationBuilder.RenameColumn(
                name: "DoadorId",
                table: "Coleta",
                newName: "DoadorID");

            migrationBuilder.RenameIndex(
                name: "IX_Coleta_FuncionarioId",
                table: "Coleta",
                newName: "IX_Coleta_FuncionarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Coleta_DoadorId",
                table: "Coleta",
                newName: "IX_Coleta_DoadorID");

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoID",
                table: "Retirada",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HospitalID",
                table: "Retirada",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Funcionario",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoID",
                table: "EstoqueSangue",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoID",
                table: "Doador",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Doador",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoID",
                table: "Coleta",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FuncionarioID",
                table: "Coleta",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoadorID",
                table: "Coleta",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Doador_DoadorID",
                table: "Coleta",
                column: "DoadorID",
                principalTable: "Doador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Funcionario_FuncionarioID",
                table: "Coleta",
                column: "FuncionarioID",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Retirada_Hospital_HospitalID",
                table: "Retirada",
                column: "HospitalID",
                principalTable: "Hospital",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Doador_DoadorID",
                table: "Coleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Funcionario_FuncionarioID",
                table: "Coleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Retirada_Hospital_HospitalID",
                table: "Retirada");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Doador");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoID",
                table: "Retirada",
                newName: "TipoSanguineoId");

            migrationBuilder.RenameColumn(
                name: "HospitalID",
                table: "Retirada",
                newName: "HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Retirada_HospitalID",
                table: "Retirada",
                newName: "IX_Retirada_HospitalId");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoID",
                table: "EstoqueSangue",
                newName: "TipoSanguineoId");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoID",
                table: "Doador",
                newName: "TipoSanguineoId");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineoID",
                table: "Coleta",
                newName: "TipoSanguineoId");

            migrationBuilder.RenameColumn(
                name: "FuncionarioID",
                table: "Coleta",
                newName: "FuncionarioId");

            migrationBuilder.RenameColumn(
                name: "DoadorID",
                table: "Coleta",
                newName: "DoadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Coleta_FuncionarioID",
                table: "Coleta",
                newName: "IX_Coleta_FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Coleta_DoadorID",
                table: "Coleta",
                newName: "IX_Coleta_DoadorId");

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoId",
                table: "Retirada",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Retirada",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoId",
                table: "EstoqueSangue",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoId",
                table: "Doador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineoId",
                table: "Coleta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FuncionarioId",
                table: "Coleta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DoadorId",
                table: "Coleta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Retirada_TipoSanguineoId",
                table: "Retirada",
                column: "TipoSanguineoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueSangue_TipoSanguineoId",
                table: "EstoqueSangue",
                column: "TipoSanguineoId");

            migrationBuilder.CreateIndex(
                name: "IX_Doador_TipoSanguineoId",
                table: "Doador",
                column: "TipoSanguineoId");

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_TipoSanguineoId",
                table: "Coleta",
                column: "TipoSanguineoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Doador_DoadorId",
                table: "Coleta",
                column: "DoadorId",
                principalTable: "Doador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Funcionario_FuncionarioId",
                table: "Coleta",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Tipo_Sanguineo_TipoSanguineoId",
                table: "Coleta",
                column: "TipoSanguineoId",
                principalTable: "Tipo_Sanguineo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doador_Tipo_Sanguineo_TipoSanguineoId",
                table: "Doador",
                column: "TipoSanguineoId",
                principalTable: "Tipo_Sanguineo",
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
