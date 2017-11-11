using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class PerguntaMapping : EntityTypeConfiguration<Pergunta>
    {
        public override void Map(EntityTypeBuilder<Pergunta> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Texto)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar(250)");

            builder.Property(e => e.Tipo)
               .IsRequired()
               .HasMaxLength(1)
               .HasColumnType("varchar(1)");

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Perguntas");
        }
    }
}
