using DotNetCoreAppExample.Domain.Core;
using FluentValidation;
using System;

namespace DotNetCoreAppExample.Domain.Vagas.Entities
{
    public class VagaSkill : EntityBase<VagaSkill>
    {
        public VagaSkill(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        protected VagaSkill() { }

        public string Nome { get; private set; }

        public Guid VagaId { get; private set; }

        //mapeamento EF
        public virtual Vaga Vaga { get; set; }

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
