using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreAppExample.Application.ViewModels
{
    public class UsuarioViewModel : ViewModelBase
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public bool IsEmpresa { get; set; }
    }
}
