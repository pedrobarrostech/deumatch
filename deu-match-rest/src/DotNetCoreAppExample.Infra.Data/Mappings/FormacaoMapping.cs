using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class FormacaoMapping : EntityTypeConfiguration<Formacao>
    {
        public override void Map(EntityTypeBuilder<Formacao> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar(150)");

            builder.Property(e => e.NomeInstituicao)
               .IsRequired()
               .HasMaxLength(150)
               .HasColumnType("varchar(150)");

            builder.Property(e => e.DataInicio)
               .IsRequired();

            builder.Property(e => e.DataFim);

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Formacoes");


            builder.HasOne(e => e.Profissional)
               .WithMany(e => e.Formacoes)
               .HasForeignKey(e => e.ProfissionalId)
               .IsRequired();
        }
    }
}

