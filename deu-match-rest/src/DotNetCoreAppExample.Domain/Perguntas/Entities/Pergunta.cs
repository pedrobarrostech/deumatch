using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace DotNetCoreAppExample.Domain.Perguntas.Entities
{
    public class Pergunta : EntityBase<Pergunta>
    {
        public Pergunta(Guid id, string texto, string tipo)
        {
            Id = id;
            Texto = texto;
            Tipo = tipo;
        }

        // Construtor para o EF
        protected Pergunta() { }

        public string Texto { get; private set; }
        public string Tipo { get; private set; }

        public virtual ICollection<Resposta> Respostas { get; private set; }
        public virtual ICollection<Questionario> Questionarios { get; set; }

        public override bool EstaValido()
        {
            RuleFor(c => c.Texto)
                .NotEmpty().WithMessage("Informe o texto.")
                .MaximumLength(150).WithMessage("O texto precisa ter até 150 caracteres.");

            RuleFor(c => c.Tipo)
                .Must(x => x == "I" || x == "V" || x == "C").WithMessage("O tipo não é válido.");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}