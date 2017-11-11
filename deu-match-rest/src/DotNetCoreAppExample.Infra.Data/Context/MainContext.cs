using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;
using DotNetCoreAppExample.Infra.Data.Extensions;
using DotNetCoreAppExample.Infra.Data.Mappings;
using System.Linq;
using System.Reflection;
using System;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Empresas.Entities;
using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Entities;

namespace DotNetCoreAppExample.Infra.Data.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }

        public DbSet<Experiencia> Experiencias { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Formacao> Formacoes { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<ProfissionalSkill> ProfissionalSkills { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<VagaSkill> VagaSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new RatingMapping());

            modelBuilder.AddConfiguration(new PerguntaMapping());
            modelBuilder.AddConfiguration(new RespostaMapping());

            modelBuilder.AddConfiguration(new ProfissionalMapping());
            modelBuilder.AddConfiguration(new ExperienciaMapping());
            modelBuilder.AddConfiguration(new FormacaoMapping());
            modelBuilder.AddConfiguration(new QuestionarioMapping());
            modelBuilder.AddConfiguration(new ProfissionalSkillMapping());
            
            modelBuilder.AddConfiguration(new UsuarioMapping());

            modelBuilder.AddConfiguration(new CandidatoMapping());
            modelBuilder.AddConfiguration(new VagaMapping());
            modelBuilder.AddConfiguration(new VagaSkillMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Property("DataCadastro").IsModified = false;
                        break;
                }
            }

            return base.SaveChanges();
        }
    }
}
