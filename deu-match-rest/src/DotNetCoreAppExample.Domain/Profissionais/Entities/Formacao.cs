using DotNetCoreAppExample.Domain.Core;
using FluentValidation;
using System;

namespace DotNetCoreAppExample.Domain.Profissionais.Entities
{
    public class Formacao : EntityBase<Formacao>
    {
        public Formacao(Guid id, DateTime dataInicio, DateTime dataFim, Guid idProfissional, string descricao, string nomeInstituicao)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            ProfissionalId = idProfissional;
            Descricao = descricao;
            NomeInstituicao = nomeInstituicao;
        }

        // Construtor para o EF
        protected Formacao() { }

        public Guid ProfissionalId { get; private set; }
        public string Descricao { get; private set; }
        public string NomeInstituicao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }

        // EF propriedades de navegacao
        public virtual Profissional Profissional { get; private set; }

        public override bool EstaValido()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Informe a descrição.")
                .MaximumLength(150).WithMessage("A descrição precisa ter até 150 caracteres.");

            RuleFor(c => c.NomeInstituicao)
                .NotEmpty().WithMessage("Informe o nome da instituição.")
                .MaximumLength(150).WithMessage("O nome da instituição precisa ter até 150 caracteres.");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}