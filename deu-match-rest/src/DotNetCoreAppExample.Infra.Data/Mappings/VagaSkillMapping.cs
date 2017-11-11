using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class VagaSkillMapping : EntityTypeConfiguration<VagaSkill>
    {
        public override void Map(EntityTypeBuilder<VagaSkill> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
              .HasColumnType("varchar(100)")
              .IsRequired();

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("VagaSkills");

            builder.HasOne(e => e.Vaga)
                .WithMany(e => e.Skills)
                .HasForeignKey(e => e.VagaId)
                .IsRequired();
        }
    }
}