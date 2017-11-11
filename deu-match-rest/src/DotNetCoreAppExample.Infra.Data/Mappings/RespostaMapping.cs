using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppExample.Infra.Data.Mappings
{
    public class RespostaMapping : EntityTypeConfiguration<Resposta>
    {
        public override void Map(EntityTypeBuilder<Resposta> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Texto)
              .IsRequired();

            builder.Property(e => e.DataCadastro)
              .IsRequired();

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);

            builder.HasOne(e => e.Pergunta)
                .WithMany(e => e.Respostas)
                .HasForeignKey(e => e.PerguntaId)
                .IsRequired();

            builder.ToTable("Respostas");
        }
    }
}
