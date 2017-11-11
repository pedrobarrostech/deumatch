using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using System;
using System.Collections.Generic;

namespace DotNetCoreAppExample.Domain.Vagas.Entities
{
    public class Vaga : EntityBase<Vaga>
    {
        public Vaga(Guid id, Guid idEmpresa, int ratingInovacao, int ratingConstrucao, int ratingVelocidade)
        {
            Id = id;
            EmpresaId = idEmpresa;
            RatingInovacao = ratingInovacao;
            RatingVelocidade = ratingVelocidade;
            RatingConstrucao = ratingConstrucao;
        }

        // Construtor para o EF
        protected Vaga() { }

        public Guid EmpresaId { get; private set; }
        public int RatingInovacao { get; private set; }
        public int RatingVelocidade { get; private set; }
        public int RatingConstrucao { get; private set; }

        // EF propriedades de navegacao
        public virtual Usuario Empresa { get; set; }
        public virtual ICollection<Candidato> Candidatos { get; set; }
        public virtual ICollection<VagaSkill> Skills { get; set; }


        public override bool EstaValido()
        {
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}