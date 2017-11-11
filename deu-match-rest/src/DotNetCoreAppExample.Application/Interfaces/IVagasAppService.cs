using DotNetCoreAppExample.Application.ViewModels;
using System.Collections.Generic;

namespace DotNetCoreAppExample.Application.Interfaces
{
    public interface IVagasAppService : IAppServiceBase<VagaViewModel>
    {
        ICollection<UsuarioViewModel> ProcessarVaga(VagaViewModel entityViewModel);
    }
}