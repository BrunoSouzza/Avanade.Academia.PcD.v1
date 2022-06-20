using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avanade.Academia.PcD.Infra.Database.Migrations
{
    public partial class AlterEntityProfessoresAndAddCursoConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_TblProfessor_ProfessorId",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblProfessor",
                table: "TblProfessor");

            migrationBuilder.RenameTable(
                name: "TblProfessor",
                newName: "Professores");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cursos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Cursos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professores",
                table: "Professores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Professores_ProfessorId",
                table: "Cursos",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Professores_ProfessorId",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professores",
                table: "Professores");

            migrationBuilder.RenameTable(
                name: "Professores",
                newName: "TblProfessor");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblProfessor",
                table: "TblProfessor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_TblProfessor_ProfessorId",
                table: "Cursos",
                column: "ProfessorId",
                principalTable: "TblProfessor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
