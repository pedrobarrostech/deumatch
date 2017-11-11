using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class ProfissionalSkillMapping : EntityTypeConfiguration<ProfissionalSkill>
    {
        public override void Map(EntityTypeBuilder<ProfissionalSkill> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
              .HasColumnType("varchar(100)")
              .IsRequired();

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("ProfissionalSkills");

            builder.HasOne(e => e.Profissional)
                .WithMany(e => e.Skills)
                .HasForeignKey(e => e.ProfissionalId)
                .IsRequired();
        }
    }
}
