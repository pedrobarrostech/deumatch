using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class QuestionarioMapping : EntityTypeConfiguration<Questionario>
    {
        public override void Map(EntityTypeBuilder<Questionario> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Questionarios");

            builder.HasOne(e => e.Profissional)
              .WithMany(e => e.Questionarios)
              .HasForeignKey(e => e.ProfissionalId)
              .IsRequired();

            builder.HasOne(e => e.Resposta)
              .WithMany(e => e.Questionarios)
              .HasForeignKey(e => e.RespostaId)
              .IsRequired();

        }
    }
}
