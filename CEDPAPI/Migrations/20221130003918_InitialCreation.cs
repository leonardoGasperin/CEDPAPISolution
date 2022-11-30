using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEDPAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(name: "E-mail", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Datadenascimento = table.Column<DateTime>(name: "Data de nascimento", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomedoCurso = table.Column<string>(name: "Nome do Curso", type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Requisitos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CargaHorária = table.Column<int>(name: "Carga Horária", type: "int", maxLength: 150, nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instrutores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(name: "E-mail", type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Valorporhora = table.Column<decimal>(name: "Valor por hora", type: "decimal(18,2)", nullable: false),
                    Certificados = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrutores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matrículas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IddaTurma = table.Column<int>(name: "Id da Turma", type: "int", nullable: false),
                    IddoEstudante = table.Column<int>(name: "Id do Estudante", type: "int", nullable: false),
                    DatadeMatrícula = table.Column<DateTime>(name: "Data de Matrícula", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matrículas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turmos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IddoInstrutor = table.Column<int>(name: "Id do Instrutor", type: "int", nullable: false),
                    IddoCurso = table.Column<int>(name: "Id do Curso", type: "int", nullable: false),
                    DatadeInício = table.Column<DateTime>(name: "Data de Início", type: "datetime2", nullable: true),
                    DatadeTérmino = table.Column<DateTime>(name: "Data de Término", type: "datetime2", nullable: true),
                    CargaHorária = table.Column<int>(name: "Carga Horária", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turmos_Cursos_Id do Curso",
                        column: x => x.IddoCurso,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turmos_Instrutores_Id do Instrutor",
                        column: x => x.IddoInstrutor,
                        principalTable: "Instrutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turmos_Id do Curso",
                table: "Turmos",
                column: "Id do Curso");

            migrationBuilder.CreateIndex(
                name: "IX_Turmos_Id do Instrutor",
                table: "Turmos",
                column: "Id do Instrutor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Matrículas");

            migrationBuilder.DropTable(
                name: "Turmos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Instrutores");
        }
    }
}
