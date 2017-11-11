using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using FluentValidation;
using System;

namespace DotNetCoreAppExample.Domain.Empresas.Entities
{
    public class Rating : EntityBase<Rating>
    {
        public Rating(Guid id, Guid idResposta, Guid idEmpresa, int valor)
        {
            Id = id;
            RespostaId = idResposta;
            EmpresaId = idEmpresa;
            Valor = valor;
        }

        // Construtor para o EF
        protected Rating() { }

        public Guid RespostaId { get; private set; }
        public Guid EmpresaId { get; private set; }
        public int Valor { get; private set; }

        // EF propriedades de navegacao
        public virtual Resposta Resposta { get; private set; }
        public virtual Usuario Empresa { get; private set; }

        public override bool EstaValido()
        {
            RuleFor(c => c.Valor)
                .InclusiveBetween(0, 10).WithMessage("O valor precisa ser de 0 a 10.");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}