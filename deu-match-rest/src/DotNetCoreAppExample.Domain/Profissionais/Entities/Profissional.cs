using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using System;
using System.Collections.Generic;

namespace DotNetCoreAppExample.Domain.Profissionais.Entities
{
    public class Profissional : EntityBase<Profissional>
    {
        public Profissional(Guid id, DateTime dataNascimento)
        {
            Id = id;
            DataNascimento = dataNascimento;
        }

        // Construtor para o EF
        protected Profissional() { }
        public DateTime DataNascimento { get; private set; }

        // EF propriedades de navegacao
        public virtual ICollection<Formacao> Formacoes { get; set; }
        public virtual ICollection<Experiencia> Experiencias { get; set; }
        public virtual ICollection<Questionario> Questionarios { get; set; }
        public virtual ICollection<ProfissionalSkill> Skills { get; set; }
        public virtual ICollection<Candidato> Candidatos { get; set; }

        public override bool EstaValido()
        {
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}