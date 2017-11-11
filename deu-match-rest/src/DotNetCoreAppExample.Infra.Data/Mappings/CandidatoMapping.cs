
using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class CandidatoMapping : EntityTypeConfiguration<Candidato>
    {
        public override void Map(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Property(e => e.DeuMatch)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.HasOne(e => e.Vaga)
               .WithMany(e => e.Candidatos)
               .HasForeignKey(e => e.VagaId)
               .IsRequired();

            builder.HasOne(e => e.Profissional)
               .WithMany(e => e.Candidatos)
               .HasForeignKey(e => e.ProfissionalId)
               .IsRequired();

            builder.ToTable("Candidatos");
        }
    }
}
