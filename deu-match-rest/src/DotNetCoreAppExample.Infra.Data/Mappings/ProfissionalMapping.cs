using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class ProfissionalMapping : EntityTypeConfiguration<Profissional>
    {
        public override void Map(EntityTypeBuilder<Profissional> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DataNascimento)
               .IsRequired();

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Profissionais");
        }
    }
}
