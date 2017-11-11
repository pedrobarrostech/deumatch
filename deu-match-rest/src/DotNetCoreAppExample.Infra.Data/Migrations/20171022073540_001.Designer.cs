using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20171022073540_001")]
    partial class _001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Empresas.Entities.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<Guid>("EmpresaId");

                    b.Property<Guid>("RespostaId");

                    b.Property<int>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("RespostaId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Perguntas.Entities.Pergunta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.ToTable("Perguntas");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Perguntas.Entities.Resposta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<Guid>("PerguntaId");

                    b.Property<string>("Texto")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PerguntaId");

                    b.ToTable("Respostas");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.Experiencia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime?>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Papel")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("ProfissionalId");

                    b.HasKey("Id");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.Formacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime?>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("NomeInstituicao")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<Guid>("ProfissionalId");

                    b.HasKey("Id");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("Formacoes");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.Profissional", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.HasKey("Id");

                    b.ToTable("Profissionais");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.ProfissionalSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProfissionalId");

                    b.HasKey("Id");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("ProfissionalSkills");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.Questionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<Guid?>("PerguntaId");

                    b.Property<Guid>("ProfissionalId");

                    b.Property<Guid>("RespostaId");

                    b.HasKey("Id");

                    b.HasIndex("PerguntaId");

                    b.HasIndex("ProfissionalId");

                    b.HasIndex("RespostaId");

                    b.ToTable("Questionarios");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Usuarios.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("IsEmpresa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Vagas.Entities.Candidato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("DeuMatch");

                    b.Property<Guid>("ProfissionalId");

                    b.Property<Guid>("VagaId");

                    b.HasKey("Id");

                    b.HasIndex("ProfissionalId");

                    b.HasIndex("VagaId");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Vagas.Entities.Vaga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<Guid>("EmpresaId");

                    b.Property<int>("RatingConstrucao");

                    b.Property<int>("RatingInovacao");

                    b.Property<int>("RatingVelocidade");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Vagas.Entities.VagaSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("VagaId");

                    b.HasKey("Id");

                    b.HasIndex("VagaId");

                    b.ToTable("VagaSkills");
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Empresas.Entities.Rating", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Usuarios.Entities.Usuario", "Empresa")
                        .WithMany("Ratings")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetCoreAppExample.Domain.Perguntas.Entities.Resposta", "Resposta")
                        .WithMany("Ratings")
                        .HasForeignKey("RespostaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Perguntas.Entities.Resposta", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Perguntas.Entities.Pergunta", "Pergunta")
                        .WithMany("Respostas")
                        .HasForeignKey("PerguntaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.Experiencia", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Profissionais.Entities.Profissional", "Profissional")
                        .WithMany("Experiencias")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.Formacao", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Profissionais.Entities.Profissional", "Profissional")
                        .WithMany("Formacoes")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.ProfissionalSkill", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Profissionais.Entities.Profissional", "Profissional")
                        .WithMany("Skills")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Profissionais.Entities.Questionario", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Perguntas.Entities.Pergunta")
                        .WithMany("Questionarios")
                        .HasForeignKey("PerguntaId");

                    b.HasOne("DotNetCoreAppExample.Domain.Profissionais.Entities.Profissional", "Profissional")
                        .WithMany("Questionarios")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetCoreAppExample.Domain.Perguntas.Entities.Resposta", "Resposta")
                        .WithMany("Questionarios")
                        .HasForeignKey("RespostaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Vagas.Entities.Candidato", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Profissionais.Entities.Profissional", "Profissional")
                        .WithMany("Candidatos")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetCoreAppExample.Domain.Vagas.Entities.Vaga", "Vaga")
                        .WithMany("Candidatos")
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Vagas.Entities.Vaga", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Usuarios.Entities.Usuario", "Empresa")
                        .WithMany("Vagas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotNetCoreAppExample.Domain.Vagas.Entities.VagaSkill", b =>
                {
                    b.HasOne("DotNetCoreAppExample.Domain.Vagas.Entities.Vaga", "Vaga")
                        .WithMany("Skills")
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
