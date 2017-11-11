using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreAppExample.Application.ViewModels
{
    public class CandidatoViewModel : ViewModelBase
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProfissionalId { get; set; }
        public Guid VagaId { get; set; }
        public bool DeuMatch { get; set; }

        public virtual ProfissionalViewModel Profissional { get; set; }
        public virtual VagaViewModel Vaga { get; set; }
    }
}
