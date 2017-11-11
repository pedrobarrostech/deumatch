using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using System;

namespace DotNetCoreAppExample.Domain.Vagas.Entities
{
    public class Candidato : EntityBase<Candidato>
    {
        public Candidato(Guid id, Guid idVaga, Guid idProfissional, bool deuMatch)
        {
            Id = id;
            VagaId = idVaga;
            ProfissionalId = idProfissional;
            DeuMatch = deuMatch;
        }

        // Construtor para o EF
        protected Candidato() { }

        public Guid ProfissionalId { get; private set; }
        public Guid VagaId { get; private set; }
        public bool DeuMatch { get; private set; }

        // EF propriedades de navegacao
        public virtual Profissional Profissional { get; set; }
        public virtual Vaga Vaga { get; set; }


        public override bool EstaValido()
        {
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}