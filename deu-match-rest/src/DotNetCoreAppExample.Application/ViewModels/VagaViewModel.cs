using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreAppExample.Application.ViewModels
{
    public class VagaViewModel : ViewModelBase
    {
        [Key]
        public Guid Id { get; set; }

        public Guid EmpresaId { get;  set; }
        public int RatingInovacao { get; set; }
        public int RatingVelocidade { get; set; }
        public int RatingConstrucao { get; set; }

        public UsuarioViewModel Empresa { get; set; }
        public ICollection<CandidatoViewModel> Candidatos { get; set; }
        public ICollection<VagaSkillViewModel> Skills { get; set; }
    }
}
