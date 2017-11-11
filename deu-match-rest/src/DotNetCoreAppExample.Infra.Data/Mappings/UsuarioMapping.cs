using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public override void Map(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(e => e.Nome)
               .HasColumnType("varchar(150)")
               .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Usuarios");
        }
    }
}