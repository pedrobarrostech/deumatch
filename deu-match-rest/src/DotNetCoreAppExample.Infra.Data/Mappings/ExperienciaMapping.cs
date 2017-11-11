using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class ExperienciaMapping : EntityTypeConfiguration<Experiencia>
    {
        public override void Map(EntityTypeBuilder<Experiencia> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Papel)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.NomeEmpresa)
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

            builder.ToTable("Experiencias");


            builder.HasOne(e => e.Profissional)
               .WithMany(e => e.Experiencias)
               .HasForeignKey(e => e.ProfissionalId)
               .IsRequired();
        }
    }
}
