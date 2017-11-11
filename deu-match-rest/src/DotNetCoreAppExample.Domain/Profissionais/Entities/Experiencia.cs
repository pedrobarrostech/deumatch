using DotNetCoreAppExample.Domain.Core;
using FluentValidation;
using System;

namespace DotNetCoreAppExample.Domain.Profissionais.Entities
{
    public class Experiencia : EntityBase<Experiencia>
    {
        public Experiencia(Guid id, DateTime dataInicio, DateTime dataFim, Guid idProfissional, string papel, string nomeEmpresa)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            ProfissionalId = idProfissional;
            Papel = papel;
            NomeEmpresa = nomeEmpresa;
        }

        // Construtor para o EF
        protected Experiencia() { }

        public Guid ProfissionalId { get; private set; }
        public string Papel { get; private set; }
        public string NomeEmpresa { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }

        // EF propriedades de navegacao
        public virtual Profissional Profissional { get; private set; }

        public override bool EstaValido()
        {
            RuleFor(c => c.Papel)
                .NotEmpty().WithMessage("Informe o papel.")
                .MaximumLength(150).WithMessage("O papel precisa ter até 150 caracteres.");

            RuleFor(c => c.NomeEmpresa)
                .NotEmpty().WithMessage("Informe o nome da empresa.")
                .MaximumLength(150).WithMessage("O nome da empresa precisa ter até 150 caracteres.");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}