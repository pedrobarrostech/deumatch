using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Usuarios.Entities;

namespace DotNetCoreAppExample.Domain.Empresas.Interfaces
{
    public interface IEmpresaRepository : IRepositoryBase<Usuario>
    {
    }
}
