using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Perguntas.Entities;
using System;

namespace DotNetCoreAppExample.Domain.Profissionais.Entities
{
    public class Questionario : EntityBase<Questionario>
    {
        public Questionario(Guid id, Guid idPergunta, Guid idProfissional, Guid idResposta)
        {
            Id = id;
            ProfissionalId = idProfissional;
            RespostaId = idResposta;
        }

        // Construtor para o EF
        protected Questionario() { }

        public Guid ProfissionalId { get; private set; }
        public Guid RespostaId { get; private set; }

        // EF propriedades de navegacao
        public virtual Profissional Profissional { get; private set; }
        public virtual Resposta Resposta { get; private set; }

        public override bool EstaValido()
        {
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}