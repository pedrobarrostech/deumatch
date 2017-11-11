using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreAppExample.Infra.Data.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perguntas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Tipo = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perguntas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profissionais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissionais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    IsEmpresa = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Respostas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    PerguntaId = table.Column<Guid>(nullable: false),
                    Texto = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respostas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Respostas_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiencias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    NomeEmpresa = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Papel = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ProfissionalId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiencias_Profissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Formacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    NomeInstituicao = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    ProfissionalId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formacoes_Profissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfissionalSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    ProfissionalId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfissionalSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfissionalSkills_Profissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<Guid>(nullable: false),
                    RatingConstrucao = table.Column<int>(nullable: false),
                    RatingInovacao = table.Column<int>(nullable: false),
                    RatingVelocidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vagas_Usuarios_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<Guid>(nullable: false),
                    RespostaId = table.Column<Guid>(nullable: false),
                    Valor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Usuarios_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Respostas_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Respostas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    PerguntaId = table.Column<Guid>(nullable: true),
                    ProfissionalId = table.Column<Guid>(nullable: false),
                    RespostaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questionarios_Perguntas_PerguntaId",
                        column: x => x.PerguntaId,
                        principalTable: "Perguntas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_Profissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionarios_Respostas_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Respostas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DeuMatch = table.Column<bool>(nullable: false),
                    ProfissionalId = table.Column<Guid>(nullable: false),
                    VagaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidatos_Profissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidatos_Vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VagaSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    VagaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagaSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VagaSkills_Vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_EmpresaId",
                table: "Ratings",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RespostaId",
                table: "Ratings",
                column: "RespostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Respostas_PerguntaId",
                table: "Respostas",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiencias_ProfissionalId",
                table: "Experiencias",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Formacoes_ProfissionalId",
                table: "Formacoes",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionalSkills_ProfissionalId",
                table: "ProfissionalSkills",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_PerguntaId",
                table: "Questionarios",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_ProfissionalId",
                table: "Questionarios",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_RespostaId",
                table: "Questionarios",
                column: "RespostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_ProfissionalId",
                table: "Candidatos",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_VagaId",
                table: "Candidatos",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_EmpresaId",
                table: "Vagas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_VagaSkills_VagaId",
                table: "VagaSkills",
                column: "VagaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Experiencias");

            migrationBuilder.DropTable(
                name: "Formacoes");

            migrationBuilder.DropTable(
                name: "ProfissionalSkills");

            migrationBuilder.DropTable(
                name: "Questionarios");

            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropTable(
                name: "VagaSkills");

            migrationBuilder.DropTable(
                name: "Respostas");

            migrationBuilder.DropTable(
                name: "Profissionais");

            migrationBuilder.DropTable(
                name: "Vagas");

            migrationBuilder.DropTable(
                name: "Perguntas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
