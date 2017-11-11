using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class VagaMapping : EntityTypeConfiguration<Vaga>
    {
        public override void Map(EntityTypeBuilder<Vaga> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Property(e => e.RatingConstrucao)
              .IsRequired();

            builder.Property(e => e.RatingInovacao)
             .IsRequired();

            builder.Property(e => e.RatingVelocidade)
             .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.HasOne(e => e.Empresa)
               .WithMany(e => e.Vagas)
               .HasForeignKey(e => e.EmpresaId)
               .IsRequired();

            builder.ToTable("Vagas");
        }
    }
}
