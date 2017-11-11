using System;
using DotNetCoreAppExample.Domain.Core;
using FluentValidation;
using System.Collections.Generic;
using DotNetCoreAppExample.Domain.Empresas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Entities;

namespace DotNetCoreAppExample.Domain.Usuarios.Entities
{
    public class Usuario : EntityBase<Usuario>
    {
        public Usuario(Guid id, string nome, bool isEmpresa)
        {
            Id = id;
            Nome = nome;
            IsEmpresa = isEmpresa;
        }

        // Construtor para o EF
        protected Usuario() { }

        public string Nome { get; private set; }
        public bool IsEmpresa { get; private set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Vaga> Vagas { get; set; }

        public override bool EstaValido()
        {
            ValidarNome();

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }

        #region [ Validações ]

        private void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe o nome do usuário.")
                .Length(2, 150).WithMessage("O nome do usuário precisa ter entre 2 e 150 caracteres.");
        }

        #endregion [ Validações ]
    }
}
