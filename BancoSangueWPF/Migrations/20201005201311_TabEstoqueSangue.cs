using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoSangueWPF.Migrations
{
    public partial class TabEstoqueSangue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome_hospital",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "Nome_responsavel",
                table: "Hospital");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Hospital",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeResponsavel",
                table: "Hospital",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "NomeResponsavel",
                table: "Hospital");

            migrationBuilder.AddColumn<string>(
                name: "Nome_hospital",
                table: "Hospital",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome_responsavel",
                table: "Hospital",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
