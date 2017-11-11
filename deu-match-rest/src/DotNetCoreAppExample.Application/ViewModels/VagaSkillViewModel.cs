using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreAppExample.Application.ViewModels
{
    public class VagaSkillViewModel : ViewModelBase
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public Guid VagaId { get; set; }

        public virtual VagaViewModel Vaga { get; set; }
    }
}
