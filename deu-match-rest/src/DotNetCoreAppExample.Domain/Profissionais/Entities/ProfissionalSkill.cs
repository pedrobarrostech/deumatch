using DotNetCoreAppExample.Domain.Core;
using FluentValidation;
using System;

namespace DotNetCoreAppExample.Domain.Profissionais.Entities
{
    public class ProfissionalSkill : EntityBase<ProfissionalSkill>
    {
        public ProfissionalSkill(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public string Nome { get; private set; }

        public Guid ProfissionalId { get; private set; }

        protected ProfissionalSkill() { }

        //mapeamento EF
        public virtual Profissional Profissional { get; set; }

        public override bool EstaValido()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe o nome.")
                .MaximumLength(150).WithMessage("O {0} precisa ter até 150 caracteres.");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
