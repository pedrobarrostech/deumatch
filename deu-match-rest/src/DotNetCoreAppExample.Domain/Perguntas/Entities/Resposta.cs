using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Empresas.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace DotNetCoreAppExample.Domain.Perguntas.Entities
{
    public class Resposta : EntityBase<Resposta>
    {
        public Resposta(Guid id, string texto)
        {
            Id = id;
            Texto = texto;
        }

        // Construtor para o EF
        protected Resposta() { }

        public string Texto { get; private set; }
        public Guid PerguntaId { get; private set; }

        // EF propriedades de navegacao
        public virtual Pergunta Pergunta { get; private set; }
        public virtual ICollection<Questionario> Questionarios { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

        public override bool EstaValido()
        {
            RuleFor(c => c.Texto)
                .NotEmpty().WithMessage("Informe o texto.")
                .MaximumLength(150).WithMessage("O texto precisa ter até 150 caracteres.");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}