using DotNetCoreAppExample.Domain.Empresas.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class RatingMapping : EntityTypeConfiguration<Rating>
    {
        public override void Map(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Valor)
              .IsRequired();

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.HasOne(e => e.Resposta)
              .WithMany(e => e.Ratings)
              .HasForeignKey(e => e.RespostaId)
              .IsRequired();

            builder.HasOne(e => e.Empresa)
             .WithMany(e => e.Ratings)
             .HasForeignKey(e => e.EmpresaId)
             .IsRequired();

            builder.ToTable("Ratings");
        }
    }
}

